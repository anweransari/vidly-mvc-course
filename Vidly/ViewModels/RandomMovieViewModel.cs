using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        //no changes made to this model
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}