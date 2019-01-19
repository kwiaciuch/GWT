using GWT.Client.Views;
using GWT.Model;
using System;
using System.Linq;
using Unity;
using Unity.Lifetime;

namespace GWT.Client
{
    internal class ControlContainer
    {
        /// <summary>
        /// The container
        /// </summary>
        private readonly IUnityContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlContainer"/> class.
        /// </summary>
        public ControlContainer()
        {
            _container = new UnityContainer();
        }

        public ItemViewControl RegisterControl(ItemDTO itemDto)
        {
            if (itemDto == null)
                throw new ArgumentNullException("itemDto");
            var control = new ItemViewControl(itemDto);
            _container.RegisterInstance(typeof(ItemViewControl), itemDto.Id.ToString(), control, new ContainerControlledLifetimeManager());
            return control;
        }

        public ItemViewControl GetItemView(ItemDTO itemDto)
        {
            if (itemDto == null)
                throw new ArgumentNullException("itemDto");

            string id = itemDto.Id.ToString();
            if (!string.IsNullOrWhiteSpace(id) && _container.IsRegistered(typeof(ItemViewControl), id))
                return (ItemViewControl)_container.Resolve(typeof(ItemViewControl), id);
            return null;
        }

        public string[] GetRegisteredObjectsIds()
        {
            return _container.Registrations.Where(x => x.MappedToType == typeof(ItemViewControl)).Select(x => x.Name).ToArray();
        }
    }
}
