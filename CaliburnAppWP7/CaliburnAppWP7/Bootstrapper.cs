namespace CaliburnAppWP7
{
    using System;
    using System.Collections.Generic;

    using Caliburn.Micro;

    using Services;
    using ViewModels;

    public class Bootstrapper : PhoneBootstrapper
    {
        private PhoneContainer Container { get; set; }

        protected override void Configure()
        {
            Container = new PhoneContainer();
            
            Container.RegisterPhoneServices(RootFrame); 
            Container.PerRequest<MainViewModel>();
            Container.Singleton<DataService>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return Container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return Container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            Container.BuildUp(instance);
        }
    }
}