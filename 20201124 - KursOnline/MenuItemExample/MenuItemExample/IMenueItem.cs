namespace MenuItemExample
{
   public interface IMenueItem
    {
        string Descriprion { get;  }
        char Code { get;  }
        int Order { set; }
        bool Action { set;  }

        void Display(int width);
    }
}