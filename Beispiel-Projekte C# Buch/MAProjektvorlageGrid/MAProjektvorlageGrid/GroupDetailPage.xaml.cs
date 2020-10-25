﻿using MAProjektvorlageGrid.Common;
using MAProjektvorlageGrid.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage für die Seite "Gruppendetails" ist unter http://go.microsoft.com/fwlink/?LinkId=234229 dokumentiert.

namespace MAProjektvorlageGrid
{
    /// <summary>
    /// Eine Seite, auf der eine Übersicht über eine einzelne Gruppe einschließlich einer Vorschau der Elemente
    /// in der Gruppe angezeigt wird.
    /// </summary>
    public sealed partial class GroupDetailPage : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper 
        { 
            get { return this.navigationHelper; } 
        }

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel 
        { 
            get { return this.defaultViewModel; } 
        }
        

        public GroupDetailPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private async void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            // TODO: Ein geeignetes Datenmodell für die problematische Domäne erstellen, um die Beispieldaten auszutauschen
            var group = await SampleDataSource.GetGroupAsync((String)e.NavigationParameter);
            this.DefaultViewModel["Group"] = group;
            this.DefaultViewModel["Items"] = group.Items;
        }

        /// <summary>
        /// Wird aufgerufen, wenn auf ein Element geklickt wird.
        /// </summary>
        /// <param name="sender">The GridView displaying the item clicked.</param>
        /// <param name="e">Ereignisdaten, die das angeklickte Element beschreiben.</param>
        void ItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Zur entsprechenden Zielseite navigieren und die neue Seite konfigurieren,
            // indem die erforderlichen Informationen als Navigationsparameter übergeben werden
            var itemId = ((SampleDataItem)e.ClickedItem).UniqueId;
            this.Frame.Navigate(typeof(ItemDetailPage), itemId);
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
    }
}