// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace KbeBalls {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class SmashControllerBase : EntityCommonController {
        
        private uFrame.MVVM.ViewModels.IViewModelManager<SmashViewModel> _SmashViewModelManager;
        
        [uFrame.IOC.InjectAttribute("Smash")]
        public uFrame.MVVM.ViewModels.IViewModelManager<SmashViewModel> SmashViewModelManager {
            get {
                return _SmashViewModelManager;
            }
            set {
                _SmashViewModelManager = value;
            }
        }
        
        public IEnumerable<SmashViewModel> SmashViewModels {
            get {
                return (SmashViewModelManager as uFrame.MVVM.ViewModels.IViewModelManager<SmashViewModel>).ViewModels;
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeSmash(((SmashViewModel)(viewModel)));
        }
        
        public virtual SmashViewModel CreateSmash() {
            return ((SmashViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModels.ViewModel CreateEmpty() {
            return new SmashViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeSmash(SmashViewModel viewModel) {
            // This is called when a SmashViewModel is created
            SmashViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            SmashViewModelManager.Remove(viewModel);
        }
    }
}
