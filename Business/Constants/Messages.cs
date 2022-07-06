using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added successfully";
        public static string ProductNameInvalid = "The product name must be at least two characters.";
        public static string ProductListed = "Products listed";
        public static string MaintenanceTime = "Maintenance time...";
        public static string ProductCountOfCategoryError = "A category can have up to ten products";
        public static string ProductNameAlreadyExists = "Product name already exists";
        public static string CategoryLimitExceded = "Category limit exceded";
        public static string AuthorizationDenied = "Authorization denied";
        public static string UserRegistered = "User registered successfully";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password error";
        public static string SuccessfulLogin = "Login successfully";
        public static string UserAlreadyExists = "User already exists";
        public static string AccessTokenCreated = "Access token created successfully";
    }
}
