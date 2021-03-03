using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication.Models
{
    public class FlowersResponse
    {
        [Required(ErrorMessage = "Пожалуйста, введите наименование товара")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите количество товара")]
        public string Quantity { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите ФИО")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите email")]
        public string Email { get; set; }


        public bool WillAttend { get; set; }
    }
}