namespace MenuItemExample
{
   public interface IMenueItem
    {
        string Descriprion { get;  }
        char Code { get;  }

        void Display(int width);
    }
}