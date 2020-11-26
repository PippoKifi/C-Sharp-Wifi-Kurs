using System;

namespace MenuItemExample
{
   public interface IMenueItem
    {
        /// <summary>
        /// Beschreibung von Menü
        /// </summary>
        string Descriprion { get;  }

        /// <summary>
        /// Auswahl Code von Menü
        /// </summary>
        ConsoleKey Code { get;  }

        /// <summary>
        /// Menü Punkt kann nicht ausgewählt werden
        /// </summary>
        bool Selectable { get; set; } //ToDO

        /// <summary>
        /// Menü Punkt ist nicht sichtbar
        /// </summary>
        bool Visible { get; set; } //ToDO


        /// <summary>
        /// Ausgabe für den User
        /// </summary>
        /// <param name="width"></param>
        void Display(int width);
    }
}