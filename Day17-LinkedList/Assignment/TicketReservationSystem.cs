using System;

class Ticket
{
    public int TicketId { get; set; }
    public string CustomerName { get; set; }
    public string MovieName { get; set; }
    public string SeatNumber { get; set; }
    public string BookingTime { get; set; }

    public Ticket(
        int ticketId,
        string customerName,
        string movieName,
        string seatNumber,
        string bookingTime)
    {
        TicketId = ticketId;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = bookingTime;
    }
}

class TicketNode
{
    public Ticket Data { get; set; }
    public TicketNode Next { get; set; }

    public TicketNode(Ticket ticket)
    {
        Data = ticket;
    }
}

class TicketReservation
{
    private TicketNode head;
    private TicketNode tail;

    public void AddTicket(Ticket ticket)
    {
        TicketNode node = new TicketNode(ticket);

        if (head == null)
        {
            head = tail = node;
            node.Next = head;
        }
        else
        {
            tail.Next = node;
            tail = node;
            tail.Next = head;
        }
    }

    public void RemoveTicket(int ticketId)
    {
        if (head == null)
            return;

        TicketNode previous = tail;
        TicketNode current = head;

        do
        {
            if (current.Data.TicketId == ticketId)
            {
                if (current == head && current == tail)
                {
                    head = tail = null;
                    return;
                }

                previous.Next = current.Next;

                if (current == head)
                    head = current.Next;

                if (current == tail)
                    tail = previous;

                tail.Next = head;

                return;
            }

            previous = current;
            current = current.Next;

        } while (current != head);
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        TicketNode current = head;

        do
        {
            Console.WriteLine(
                $"Ticket: {current.Data.TicketId} | " +
                $"Customer: {current.Data.CustomerName} | " +
                $"Movie: {current.Data.MovieName} | " +
                $"Seat: {current.Data.SeatNumber} | " +
                $"Time: {current.Data.BookingTime}");

            current = current.Next;

        } while (current != head);
    }

    public void SearchByCustomer(string customerName)
    {
        if (head == null)
            return;

        TicketNode current = head;

        do
        {
            if (current.Data.CustomerName.Equals(
                customerName,
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(current.Data.TicketId);
            }

            current = current.Next;

        } while (current != head);
    }

    public void SearchByMovie(string movieName)
    {
        if (head == null)
            return;

        TicketNode current = head;

        do
        {
            if (current.Data.MovieName.Equals(
                movieName,
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(current.Data.TicketId);
            }

            current = current.Next;

        } while (current != head);
    }

    public int CountTickets()
    {
        if (head == null)
            return 0;

        int count = 0;
        TicketNode current = head;

        do
        {
            count++;
            current = current.Next;

        } while (current != head);

        return count;
    }
}