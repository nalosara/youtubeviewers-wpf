﻿using DemoApp.Domain.Models;
using DemoApp.WPF.Stores;
using DemoApp.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.WPF.Commands
{
    public class AddYouTubeViewerCommand : AsyncCommandBase
    {
        private readonly AddYouTubeViewerViewModel _addYouTubeViewerViewModel;
        private readonly YouTubeViewersStore _youTubeViewersStore;
        private readonly ModalNavigationStore _modalNavigationStore;
        public AddYouTubeViewerCommand(AddYouTubeViewerViewModel addYouTubeViewerViewModel, YouTubeViewersStore youTubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            _addYouTubeViewerViewModel = addYouTubeViewerViewModel;
            _youTubeViewersStore = youTubeViewersStore;
            _modalNavigationStore = modalNavigationStore;
        }
        public override async Task ExecuteAsync(object parameter)
        {
            YouTubeViewerDetailsFormViewModel formViewModel = _addYouTubeViewerViewModel.YouTubeViewerDetailsFormViewModel;
            YouTubeViewer youTubeViewer = new YouTubeViewer(
                Guid.NewGuid(),
                formViewModel.Username, 
                formViewModel.IsSubscribed, 
                formViewModel.IsMember);

            try
            {
                await _youTubeViewersStore.Add(youTubeViewer);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
            
        }
    }
}
