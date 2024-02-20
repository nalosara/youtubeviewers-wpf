using DemoApp.WPF.Stores;
using DemoApp.WPF.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data;
using System.Windows;
using YouTubeViewers.Domain.Commands;
using YouTubeViewers.Domain.Queries;
using YouTubeViewers.EntityFramework;
using YouTubeViewers.EntityFramework.Commands;
using YouTubeViewers.EntityFramework.Queries;

namespace DemoApp.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedYouTubeViewerStore _viewerStore;
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly YouTubeViewersStore _youTubeViewersStore;
        private readonly YouTubeViewersDbContextFactory _youTubeViewersDbContextFactory;
        private readonly IGetAllYouTubeViewersQuery _getAllYouTubeViewerQuery;
        private readonly ICreateYouTubeViewerCommand _createYouTubeViewerCommand;
        private readonly IUpdateYouTubeViewerCommand _updateYouTubeViewerCommand;
        private readonly IDeleteYouTubeViewerCommand _deleteYouTubeViewerCommand;

        public App() 
        {
            string connectionString = "Data Source=YouTubeViewers.db";
            _youTubeViewersDbContextFactory = new YouTubeViewersDbContextFactory
                (new DbContextOptionsBuilder().UseSqlite(connectionString).Options);
            _getAllYouTubeViewerQuery = new GetAllYouTubeViewersQuery(_youTubeViewersDbContextFactory);
            _createYouTubeViewerCommand = new CreateYouTubeViewerCommand(_youTubeViewersDbContextFactory);
            _updateYouTubeViewerCommand = new UpdateYouTubeViewerCommand(_youTubeViewersDbContextFactory);
            _deleteYouTubeViewerCommand = new DeleteYouTubeViewerCommand(_youTubeViewersDbContextFactory);
            _modalNavigationStore = new ModalNavigationStore();
            _youTubeViewersStore = new YouTubeViewersStore(_getAllYouTubeViewerQuery, _createYouTubeViewerCommand, _updateYouTubeViewerCommand, _deleteYouTubeViewerCommand);
            _viewerStore = new SelectedYouTubeViewerStore(_youTubeViewersStore);
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            using(YouTubeViewerDbContext context = _youTubeViewersDbContextFactory.Create())
            {
                context.Database.Migrate();
            }
            YouTubeViewersViewModel youTubeViewersViewModel = new YouTubeViewersViewModel(_youTubeViewersStore, _viewerStore, _modalNavigationStore);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, youTubeViewersViewModel)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}