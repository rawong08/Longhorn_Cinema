﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AWO_Team14.Models
{
    public enum Status
    {
        Pending, Active, Returned, Cancelled
    }

    public class UserTicket
    {

        public Int32 UserTicketID { get; set; }
        
        [Display(Name = "Price")]
        public Decimal CurrentPrice { get; set;}

        //[Display(Name = "Seat Number")]
        //[Required(ErrorMessage = "Seat Number is required")]
        public Seat SeatNumber { get; set; }

        public Status Status { get; set; }

        public Int32 MovieID { get; set; }

        public string Email { get; set; }

        public string AppliedDiscounts { get; set; }

        public virtual Transaction Transaction { get; set; }
        public virtual Showing Showing { get; set; }

        public UserTicket()
        {
            if (AppliedDiscounts == null)
            {
                AppliedDiscounts = "";
            }

        }

    }
}