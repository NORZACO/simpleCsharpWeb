using System;

namespace MWAMUZISCODEV.controller
{
    public class User
    {
        string _username;
        string _password;
        string _email;
        string _phone;
        string _address;
        int _age;

        // constructor
        public User(string username, string password, string email, string phone, string address, int age)
        {
            _username = username;
            _password = password;
            _email = email;
            _phone = phone;
            _address = address;
            _age = age;
        }

        // getter
        public string getUsername()
        {
            return _username;
        }

        public string getPassword()
        {
            return _password;
        }

        public string getEmail()
        {
            return _email;
        }

        public string getPhone()
        {
            return _phone;
        }

        public string getAddress()
        {
            return _address;
        }

        public int getAge()
        {
            return _age;
        }

        // setter
        public void setUsername(string username)
        {
            _username = username;
        }

        // get all info
        public string getInfo()
        {
            return "\nUsername: " + _username + "\nPassword: " + _password + "\nEmail: " + _email + "\nPhone: " + _phone + "\nAddress: " + _address + "\nAge: " + _age;
        }


    }
}
