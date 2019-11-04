using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using belt_exam.Models;

namespace belt_exam
{
    public class RSVP{
        [Key]
        public int id{get; set;}
        public int UserId{get; set;}
        public int EventId{get; set;}
        public User User{get; set;}
        public Event Event{get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
    public DateTime UpdatedAt{get; set;} = DateTime.Now;
        public RSVP(){}
    }
}