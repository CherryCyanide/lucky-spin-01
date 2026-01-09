using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {

        public IActionResult Index(int luck) 
        {
            //DONE: add your string builder and HTML from Exercise 0 here
            int[] spin = new int[] { new Random().Next(10), new Random().Next(10), new Random().Next(10) };

            System.Text.StringBuilder htmlToShow =  
            new System.Text.StringBuilder("<body><h1> </h1><button onclick='history.go(0)'>Spin</button>");
            htmlToShow.Append("<div>" + spin[0] + "</div>");
            htmlToShow.Append("<div>" + spin[1] + "</div>");
            htmlToShow.Append("<div>" + spin[2] + "</div>");
            foreach (int num in spin) 
                {
                    if (num == luck)
                    {
                        htmlToShow.Append("<img src='http://studentfolders.cascadia.edu/itweb285/LuckySpinCoins.jpg'/></body>");
                        break;
                    }
                } 
                

            //DONE: Modify this to use the string builder's response string as the Content property's value
            return new ContentResult { Content = $"<h1>We're Ready to Spin with Lucky Number {luck} </h1>" + htmlToShow.ToString(), ContentType="text/html"};
        }
    }
}