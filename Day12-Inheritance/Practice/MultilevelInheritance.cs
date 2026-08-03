using System;

namespace Practice
{
    // Order -> ShippedOrder -> DeliveredOrder

    class Order
    {
        protected int orderId;
        protected string orderDate;

        public Order(int orderId, string orderDate)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
        }

        public virtual void GetOrderStatus()
        {
            Console.WriteLine($"Order ID   : {orderId}");
            Console.WriteLine($"Order Date : {orderDate}");
            Console.WriteLine("Status     : Order Placed");
        }
    }

    class ShippedOrder : Order
    {
        protected string trackingNumber;

        public ShippedOrder(int orderId, string orderDate, string trackingNumber)
            : base(orderId, orderDate)
        {
            this.trackingNumber = trackingNumber;
        }

        public override void GetOrderStatus()
        {
            base.GetOrderStatus();
            Console.WriteLine($"Tracking No : {trackingNumber}");
            Console.WriteLine("Status      : Order Shipped");
        }
    }

    class DeliveredOrder : ShippedOrder
    {
        private string deliveryDate;

        public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate)
            : base(orderId, orderDate, trackingNumber)
        {
            this.deliveryDate = deliveryDate;
        }

        public override void GetOrderStatus()
        {
            base.GetOrderStatus();
            Console.WriteLine($"Delivery Date : {deliveryDate}");
            Console.WriteLine("Status        : Order Delivered");
        }
    }

    // Course -> OnlineCourse -> PaidOnlineCourse

    class Course
    {
        protected string courseName;
        protected string duration;

        public Course(string courseName, string duration)
        {
            this.courseName = courseName;
            this.duration = duration;
        }

        public virtual void DisplayCourse()
        {
            Console.WriteLine($"Course   : {courseName}");
            Console.WriteLine($"Duration : {duration}");
        }
    }

    class OnlineCourse : Course
    {
        protected string platform;
        protected bool isRecorded;

        public OnlineCourse(string courseName, string duration, string platform, bool isRecorded)
            : base(courseName, duration)
        {
            this.platform = platform;
            this.isRecorded = isRecorded;
        }

        public override void DisplayCourse()
        {
            base.DisplayCourse();
            Console.WriteLine($"Platform : {platform}");
            Console.WriteLine($"Recorded : {isRecorded}");
        }
    }

    class PaidOnlineCourse : OnlineCourse
    {
        private double fee;
        private double discount;

        public PaidOnlineCourse(string courseName, string duration, string platform,
            bool isRecorded, double fee, double discount)
            : base(courseName, duration, platform, isRecorded)
        {
            this.fee = fee;
            this.discount = discount;
        }

        public override void DisplayCourse()
        {
            base.DisplayCourse();
            Console.WriteLine($"Fee      : ₹{fee}");
            Console.WriteLine($"Discount : {discount}%");
        }
    }
}