using BusinessLayer;
using DomainLayer;
using DomainLayer.Enums;
using DomainLayer.Models;
using System;
using System.Data.SqlClient;

namespace ConApp
{  
    class EmployeePortal
    {
        private static AuthenticationModule _authenticationModule;
        public EmployeePortal()
        {
            _authenticationModule = new AuthenticationModule();
        }

        /// <summary>
        /// To get the choice of user
        /// </summary>
        public void UserControl()
        {
            int option = 0;
            while (option != 3)
            {
                Console.WriteLine(StringLiterals.UserChoice);
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            EmployeePortal.LoginOption();
                            break;
                        }

                    case 2:
                        {
                            EmployeePortal.RegistrationOption();
                            break;
                        }

                    case 3:
                        {
                            break;
                        }
                }
            }
        }
        /// <summary>
        /// Login Credintals
        /// </summary>
        private static void LoginOption()
        {
            
            LoginModel loginModel = new LoginModel();
            Console.WriteLine(StringLiterals.Login + StringLiterals.EmailId);
            loginModel.EmailId = Console.ReadLine();
            Console.WriteLine(StringLiterals.Password);
            loginModel.Password = Console.ReadLine();
            string access = _authenticationModule.Login(loginModel);

            if (access == StringLiterals.LoginSuccessful)
            {
                Console.WriteLine(access);
                EmployeePortal.DisplayControl();
            }
            else
            {
                Console.WriteLine(access);
            }
        }

        /// <summary>
        /// Registration of a new user
        /// </summary>
        private static void RegistrationOption()
        {
            RegistrationModel registrationModel = new RegistrationModel();
            Console.WriteLine(StringLiterals.Registration + StringLiterals.EmailId);
            registrationModel.EmailId = Console.ReadLine();
            Console.WriteLine(StringLiterals.ValidPassword);
            registrationModel.Password = Console.ReadLine();
            Console.WriteLine(StringLiterals.ConfirmPassword);
            registrationModel.ConfirmPassword = Console.ReadLine();
            Console.WriteLine(StringLiterals.FirstName);
            registrationModel.FirstName = Console.ReadLine();
            Console.WriteLine(StringLiterals.LastName);
            registrationModel.LastName = Console.ReadLine();
            Console.WriteLine(StringLiterals.IsStudent);
            registrationModel.IsStudent = Console.ReadLine();
            if (Validations.ValidateEmail(registrationModel.EmailId)
                && Validations.ValidatePassword(registrationModel.Password)
                && Validations.VerifyPassword(registrationModel.Password, registrationModel.ConfirmPassword)
                && Validations.ValidateName(registrationModel.FirstName) && Validations.ValidateName(registrationModel.LastName))
            {
                Console.WriteLine(_authenticationModule.Register(registrationModel));
            }
            else
            {
                Console.WriteLine(StringLiterals.InvalidDetails);
            }
        }

        /// <summary>
        /// Display the data
        /// </summary>
        private static void DisplayControl()
        {
            int displayOption = 0;
            while(displayOption != 4)
            {
                Console.WriteLine(StringLiterals.DisplayControl);
                displayOption = int.Parse(Console.ReadLine());

                switch(displayOption)
                {
                    case 1:
                        {
                            EmployeePortal.SqlDataRead(UserChoiceEnum.Student);
                            break;
                        }

                    case 2:
                        {
                            EmployeePortal.SqlDataRead(UserChoiceEnum.Other);
                            break;
                        }

                    case 3:
                        {
                            EmployeePortal.SqlDataRead(UserChoiceEnum.All);
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine(StringLiterals.LogOutSuccessful);
                            break;
                        }

                }
            }

        }

        /// <summary>
        /// Displays the data of particular option
        /// </summary>
        /// <param name="op"></param>
        private static void SqlDataRead(UserChoiceEnum op)
        {
            UserModule userModule = new UserModule();
            SqlDataReader tab = userModule.GetUserDetails(op);
            Console.WriteLine(StringLiterals.TableData);

            while (tab.Read())
            {
                for (int i = 0; i < tab.FieldCount; i++)
                {
                    Console.Write(tab.GetValue(i) + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
