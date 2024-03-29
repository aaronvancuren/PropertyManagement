﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PropertyManagement.Models.Comments
{
    public class CommentCreate
    {
        [Required]
        public int ListingId { get; set; }

        [Required]
        [MaxLength(280, ErrorMessage = "There are too many characters in this field.")]
        public string Content { get; set; }

        public List<SelectListItem> Listings { get; set; }
    }
}