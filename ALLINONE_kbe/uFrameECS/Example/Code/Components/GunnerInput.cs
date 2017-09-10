// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrameECSExample {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.ECS.Components;
    using uFrame.Json;
    using UniRx;
    using UnityEngine;
    using UnityEngine.UI;
    
    
    [uFrame.Attributes.ComponentId(3)]
    [uFrame.Attributes.uFrameIdentifier("b597d2ff-160f-4f2c-a82f-66f832fd006d")]
    public partial class GunnerInput : uFrame.ECS.Components.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Button _MyButton;
        
        private Subject<PropertyChangedEvent<Button>> _MyButtonObservable;
        
        private PropertyChangedEvent<Button> _MyButtonEvent;
        
        public override int ComponentId {
            get {
                return 3;
            }
        }
        
        public IObservable<PropertyChangedEvent<Button>> MyButtonObservable {
            get {
                return _MyButtonObservable ?? (_MyButtonObservable = new Subject<PropertyChangedEvent<Button>>());
            }
        }
        
        public Button MyButton {
            get {
                return _MyButton;
            }
            set {
                SetMyButton(value);
            }
        }
        
        public virtual void SetMyButton(Button value) {
            SetProperty(ref _MyButton, value, ref _MyButtonEvent, _MyButtonObservable);
        }
    }
}