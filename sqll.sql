create table banking.branches(
branch_id serial primary key,
branch_name varchar(100) not null,
branch_code varchar(20) not null unique,
city varchar(50) not null,
address varchar(200) not null
)


create table banking.customers (
    customer_id serial primary key,
    first_name varchar(50) not null,
    last_name varchar(50) not null,
    email varchar(100) not null unique,
    phone varchar(15) not  null unique,
    date_of_birth date not null,
    branch_id int not null,

    constraint fk_customer_branch
        foreign key (branch_id)
        references banking.branches(branch_id),

    constraint chk_customer_email
        check (email LIKE '%@%')
);


create table banking.loan_types (
    loan_type_id serial primary key,
    loan_type_name varchar(50) not null unique,
    interest_rate numeric(5,2) not null,
    max_amount numeric(15,2) not null,

    constraint chk_interest_rate check (interest_rate >= 0),
    constraint chk_max_amount
        check (max_amount > 0)
);


create table banking.loans(
loan_id serial primary key,
loan_number varchar(30) not null unique,
customer_id int not null,
loan_type_id int not null,
branch_id int not null,
principal_amount numeric(15,2) not null,
loan_date date not null,
tenure_months int not null,
status varchar(30) not null default 'ACTIVE',
constraint fk_loan_customer foreign key(customer_id) references banking.customers(customer_id),
constraint fk_loan_type foreign key(loan_type_id) references banking.loan_types(loan_type_id),
constraint fk_loan_branch foreign key(branch_id) references banking.branches(branch_id),
constraint chk_principal check(principal_amount >0),
constraint chk_tenure check(tenure_months >0),
constraint chk_loan_status check(status in('ACTIVE', 'CLOSED', 'DEFAULT'))
);



create table banking.installments(
installment_id serial primary key,
loan_id int not null,
installment_number int not null,
due_date date not null,
principal_due numeric(15,2) not null,
interest_due numeric(15, 2) not null,
status varchar(30) not null default 'PENDING',

constraint fk_installment_loan foreign key(loan_id) references banking.loans(loan_id) on delete cascade,
constraint chk_installment_number check(installment_number>0),
constraint chk_principal_due check(principal_due>=0),
constraint chk_interest_due check (interest_due>=0),
constraint chk_installment_status check(status in('PENDING','PAID','OVERDUE'))
);


create table banking.payments(
payment_id serial primary key,
installment_id int not null,
payment_date date not null default current_date,
amount numeric(15,2) not null,
principal_paid numeric(15,2) not null,
interest_paid numeric(15,2) not null,

constraint fk_payment_installment foreign key(installment_id) references banking.installments(installment_id),
constraint chk_payment_amount check(amount>0),
constraint chk_principal_paid check (principal_paid>=0),
constraint chk_interest_paid check(interest_paid>=0),
constraint chk_payment_breakdown check (amount=principal_paid+interest_paid)
);


insert into banking.branches(branch_name, branch_code, city, address) values 
('Main Branch', 'BR001', 'Delhi', 'CP'),
('North Branch', 'BR002', 'Gurgaon', 'MG Road'),
('South Branch', 'BR003','Noida','Sector 18');


insert into banking.customers(first_name, last_name,email,phone,date_of_birth,branch_id) values
('Prashansa','Kumari','prashansa@gmail.com','8765456789','2006-01-08', 1),
('Ram','Kumar','ram@gmail.com','9876787654','2004-08-23', 2),
('Shyam','Gopal','shyam@gmail.com','9874568756','2002-04-15', 1),
('Priya','Singh','priya@gmail.com','9657890657','2000-05-21', 3);

insert into banking.loan_types(loan_type_name, interest_rate, max_amount) values
('Home Loan', 7.50, 1000000),
('Personal loan', 11.50, 2000000),
('CarLoan', 9.00, 3000000),
('Education loan', 6.50, 210000);

insert into banking.loans(loan_number,customer_id,loan_type_id,branch_id,principal_amount,loan_date,tenure_month,status) values
('LN1001',1,1,1,50000,'2026-01-10', 60, 'ACTIVE'),
('LN1002',2,2,2,200000,'2026-02-15', 12, 'ACTIVE'),
('LN1003',3,3,1,80000,'2026-03-01',48,'ACTIVE'),
('LN1004',4,4,3, 100000, '2026-04-10',24,'ACTIVE');

insert into banking.installments(loan_id,installment_number,due_date,principal_due,interest_due,status) values
(1,1,'2026-07-10', 7000, 3000, 'OVERDUE'),
(1,2,'2026-08-10', 7100, 2900, 'OVERDUE'),
(1,3,'2026-09-10', 7200, 2800, 'PENDING'),
(2,1,'2026-08-15',8000,2000,'OVERDUE'),
(2,2,'2026-09-15',8200,1800,'PENDING'),
(3,1,'2026-08-01',15000,5000,'OVERDUE'),
(3,2,'2026-09-15',15500,1800,'PENDING'),
(4,1,'2026-09-10',4000,1000,'PENDING');


insert into banking.payments(installment_id,payment_date,amount,principal_paid,interest_paid) values
(1,'2026-07-10',10000,7000,3000),
(4,'2026-08-15',10000,8000,2000),
(6,'2026-08-01', 20000,15000,5000);


-- 1. join: display loan, customer, loan type and branch information
select l.loan_number,c.first_name || c.last_name as customer_name,
lt.loan_type_name, l.principal_amount,
b.branch_name,l.status
from banking.loans l
join banking.customers c on l.customer_id =c.customer_id
join banking.loan_types lt on l.loan_type_id = lt.loan_type_id
join banking.branches b on l.branch_id=b.branch_id;


-- 2. cte: calculate outstanding principal for each loan
with paid_amount as(
select i.loan_id,
coalesce(sum(p.principal_paid),0) as total_principal_paid
from banking.installments i 
left join banking.payments p
on i.installment_id=p.installment_id
group by i.loan_id
)
select 
l,loan_number, l.principal_amount,
pa.total_principal_paid,
l.principal_amount-pa.total_principal_paid
as outstanding_principal
from banking.loans l
join paid_amount pa on l.loan_id=pa.loan_id;

-- 3. supporting query: calculate the average loan amount
select avg(principal_amount) from banking.loans;

-- 4. subquery: find customers having loan amounts above average
select
    c.customer_id,c.first_name,c.last_name,l.loan_number,l.principal_amount
from banking.customers c
join banking.loans l
    on c.customer_id = l.customer_id
where l.principal_amount >
(
    select avg(principal_amount)
    from banking.loans
);

-- 5. temporary table: store overdue installments
create temporary table overdue_installments as
select
    i.installment_id,l.loan_number,c.first_name || ' ' || c.last_name as customer_name,i.installment_number,i.due_date,i.principal_due,i.interest_due,
	i.principal_due + i.interest_due as total_due
from banking.installments i join banking.loans l on i.loan_id = l.loan_id
join banking.customers c on l.customer_id = c.customer_id
where i.due_date < DATE '2026-09-28' and i.status <> 'PAID';

-- 6. view: show loan repayment status
create or replace view banking.loan_repayment_status as
select
    l.loan_id,l.loan_number,c.first_name || ' ' || c.last_name as customer_name,l.principal_amount,
    coalesce(sum(p.principal_paid), 0) as principal_paid,
    l.principal_amount - coalesce(sum(p.principal_paid), 0) as outstanding_principal,
    l.status as loan_status
from banking.loans l
join banking.customers c on l.customer_id = c.customer_id
left join banking.installments i on l.loan_id = i.loan_id
left join banking.payments p on i.installment_id = p.installment_id
group by l.loan_id,l.loan_number,c.first_name,c.last_name, l.principal_amount,l.status;



select * from banking.loan_repayment_status;

select * from banking.loan_repayment_status where outstanding_principal > 0;


-- 7. udf: calculate outstanding principal for a particular loan
create or replace function banking.calculate_outstanding_principal(p_loan_id int)
returns numeric
language plpgsql
as $$
declare
    v_principal numeric;
    v_paid numeric;
begin
    select principal_amount into v_principal from banking.loans where loan_id = p_loan_id;

    select coalesce(sum(p.principal_paid), 0)
    into v_paid
    from banking.installments i
    left join banking.payments p on i.installment_id = p.installment_id where i.loan_id = p_loan_id;
    return v_principal - v_paid;
end;
$$;


-- 8. trigger function: automatically update installment status
create or replace function banking.update_installment_status()
returns trigger
language plpgsql
as $function$
declare
    v_total_paid numeric;
    v_total_due numeric;
begin
    select coalesce(sum(amount), 0)
    into v_total_paid
    from banking.payments
    where installment_id = new.installment_id;

    select principal_due + interest_due into v_total_due from banking.installments where installment_id = new.installment_id;

    if v_total_paid >= v_total_due then
        update banking.installments
        set status = 'paid'
        where installment_id = new.installment_id;
    end if;

    return new;
end;
$function$;

-- create trigger to run after a payment is inserted
create trigger trg_update_installment_status
after insert on banking.payments
for each row
execute function banking.update_installment_status();


-- 9. stored procedure: process a loan payment
create or replace procedure banking.process_loan_payment(p_installment_id int,p_amount numeric)
language plpgsql
as $function$
declare
    v_principal_due numeric;
    v_interest_due numeric;
    v_total_due numeric;
    v_paid numeric;
    v_remaining numeric;
    v_principal_payment numeric;
    v_interest_payment numeric;
begin
    select
        principal_due,
        interest_due
    into
        v_principal_due,
        v_interest_due
    from banking.installments
    where installment_id = p_installment_id
    for update;

    if not found then
        raise exception 'installment % does not exist', p_installment_id;
    end if;

    if p_amount <= 0 then
        raise exception 'payment amount must be greater than zero';
    end if;
    v_total_due := v_principal_due + v_interest_due;
    select coalesce(sum(amount), 0)
    into v_paid
    from banking.payments
    where installment_id = p_installment_id;
    v_remaining := v_total_due - v_paid;
    if p_amount > v_remaining then
        raise exception 'payment exceeds remaining amount. remaining: %', v_remaining;
    end if;

    v_interest_payment := least(p_amount, greatest(v_interest_due, 0));
    v_principal_payment := p_amount - v_interest_payment;
    insert into banking.payments
    (
        installment_id,payment_date,amount, principal_paid,interest_paid
    )
    values
    (
        p_installment_id,current_date,p_amount,v_principal_payment,v_interest_payment
    );

    raise notice 'payment of % processed for installment %',p_amount,p_installment_id;
end;
$function$;


call banking.process_loan_payment(5, 5000);
select * from banking.payments where installment_id = 5;
select * from banking.installments where installment_id = 5;

-- 10. cursor: generate overdue loan report
create or replace procedure banking.generate_overdue_report()
language plpgsql
as $function$
declare
    v_record record;
    overdue_cursor cursor for
        select
            l.loan_number,c.first_name || ' ' || c.last_name as customer_name,i.installment_number,i.due_date,i.principal_due + i.interest_due as amount_due
        from banking.installments i
        join banking.loans l on i.loan_id = l.loan_id
        join banking.customers c on l.customer_id = c.customer_id
        where i.due_date < current_date and i.status <> 'PAID' order by i.due_date;
begin
    open overdue_cursor;
    loop
        fetch overdue_cursor into v_record;
        exit when not found;
        raise notice
            'loan: %, customer: %, installment: %, due date: %, amount: %',v_record.loan_number,v_record.customer_name,v_record.installment_number, v_record.due_date,v_record.amount_due;
    end loop;

    close overdue_cursor;
end;
$function$;


call banking.generate_overdue_report();


-- 11. locking-row-level locking
begin;

select *
from banking.installments
where installment_id = 5
for update;

commit;

-- 12. dcl: create loan officer role
create role loan_officer login password 'loanofficer123';

-- allow the loan officer to connect to the database
grant connect on database banking_loan_db to loan_officer;
-- allow access to the banking schema
grant usage on schema banking to loan_officer;
-- allow select, insert and update operations on tables
grant select, insert, update on all tables in schema banking to loan_officer;
-- allow the role to use sequences
grant usage, select on all sequences in schema banking to loan_officer;
-- allow execution of the outstanding principal function
grant execute on function banking.calculate_outstanding_principal(int) to loan_officer;
-- allow execution of the loan payment procedure
grant execute on procedure banking.process_loan_payment(int, numeric) to loan_officer;

-- prevent the loan officer from deleting records
revoke delete on all tables in schema banking from loan_officer;

-- 13. check all tables in the banking schema
select table_schema,table_name from information_schema.tables where table_schema = 'banking' order by table_name;

-- select * from banking.loan_repayment_status;

-- select indexname, tablename,indexdef from pg_indexes where schemaname = 'banking' order by tablename, indexname;

-- select loan_id,loan_number, banking.calculate_outstanding_principal(loan_id) as outstanding_principal from banking.loans;

-- select installment_id,loan_id,installment_number,due_date,principal_due,interest_due,status from banking.installments order by installment_id;


-- call banking.generate_overdue_report();



select l.loan_number,c.first_name || ' ' || c.last_name as customer_name,lt.loan_type_name,l.principal_amount, coalesce(sum(p.principal_paid), 0) as principal_paid,
    l.principal_amount - coalesce(sum(p.principal_paid), 0) as outstanding_principal, l.status
from banking.loans l join banking.customers c on l.customer_id = c.customer_id
join banking.loan_types lt on l.loan_type_id = lt.loan_type_id
left join banking.installments i on l.loan_id = i.loan_id
left join banking.payments p on i.installment_id = p.installment_id
group byl.loan_id,l.loan_number,c.first_name,c.last_name,lt.loan_type_name,l.principal_amount,l.status order by l.loan_id;







