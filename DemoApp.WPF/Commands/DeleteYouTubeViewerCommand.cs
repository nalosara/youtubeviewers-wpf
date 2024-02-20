using DemoApp.Domain.Models;
using DemoApp.WPF.Stores;
using DemoApp.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.WPF.Commands
{
    internal class DeleteYouTubeViewerCommand : AsyncCommandBase
    {
        
        private readonly YouTubeViewersListingItemViewModel _youTubeViewersListingItemViewModel;
        private readonly YouTubeViewersStore _youTubeViewersStore;

        public DeleteYouTubeViewerCommand(YouTubeViewersListingItemViewModel youTubeViewersListingItemViewModel, YouTubeViewersStore youTubeViewersStore)
        {
            _youTubeViewersListingItemViewModel = youTubeViewersListingItemViewModel;
            _youTubeViewersStore = youTubeViewersStore;
        }


        public override async Task ExecuteAsync(object parameter)
        {
            YouTubeViewer youTubeViewer = _youTubeViewersListingItemViewModel.YouTubeViewer;

            try
            {
                await _youTubeViewersStore.Delete(youTubeViewer.Id);
            }
            catch (Exception)
            {

                throw;
            }

            
        }
    }
}
