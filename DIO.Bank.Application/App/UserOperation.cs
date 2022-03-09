using System;
using DIO.Bank.Application.Interface;

namespace DIO.Bank.Application.App
{
    public class UserOperation : IUserOperation
    {
        private void ClearConsole()
        {
            Console.Clear();
        }

        public void Deposit()
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteAction(string args)
        {
            throw new System.NotImplementedException();
        }

        public void Exit()
        {
            Console.WriteLine(Environment.NewLine + "Thanks for using our systems");
        }

        public bool GetList()
        {
            throw new System.NotImplementedException();
        }

        public bool Insert()
        {
            throw new System.NotImplementedException();
        }

        public bool Transfer()
        {
            throw new System.NotImplementedException();
        }

        public bool Withdraw()
        {
            throw new System.NotImplementedException();
        }
    }
}