using DIO.Bank.Application.Interface;

namespace DIO.Bank.Application.App
{
    public class App
    {
        private readonly IUserInterface _userInterface;
        public App()
        {
            _userInterface = new UserInterface();
        }

        public void Init()
        {

        }
        
    }
}