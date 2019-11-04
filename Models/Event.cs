using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace belt_exam.Models
{
    public class Event{
        [Key]
        public int EventId{get; set;}
        [MinLength(2)]
        public string Title{get; set;}
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Date{get; set;}
        [Required]
        public DateTime Time{get; set;}
        [Required]
        [MinLength(10)]
        public string Description {get; set;}
        [Required]
        public string Duration{get; set;}
        public DateTime CreatedAt{get; set;} = DateTime.Now;
        public DateTime UpdatedAt{get; set;} = DateTime.Now;
        public string Creator{get; set;} 
        public List<RSVP> Participants{get; set;}
        public Event(){
          
        }
    }
}