using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MWAMUZISCODEV.controller;

namespace MWAMUZISCODEV.Pages
{
    public class ContactModel(ILogger<ContactModel> loggers) : PageModel
    {
        private readonly ILogger<ContactModel> _logger = loggers;

        public void OnGet()
        {
            // This method is called when the page is requested using HTTP GET.
            _logger.LogInformation("Contact form loaded.");
        }

// username /* string password, string email, string phone, string address, int age  */
        public void OnPost(string? username, string? password, string? email, string? phone, string? address, int age
        ) {
            // This method is called when the page is submitted using HTTP POST.
            // You can handle form submissions or other POST actions here.

            // Example: Logging a message when the form is submitted
            _logger.LogInformation("Form Submitted");
            if (string.IsNullOrEmpty(username) ||  string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) ||  string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                _logger.LogError("Both username and password are required.");
            }
            else
            {
                // sett string username, string password, string email, string phone, string address, int age
                User person = new User(username, password, email, phone, address,age);
                _logger.LogInformation("User created.");
                _logger.LogInformation("User details:");
                _logger.LogInformation("Username: {0}", person.getInfo());
            }
        }

    }
}
