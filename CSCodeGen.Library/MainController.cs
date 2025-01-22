using System;
using System.Collections.Generic;

namespace CSCodeGen.Library
{
    public class MainController
    {
        private static readonly Dictionary<Type, object> _controller = new Dictionary<Type, object>();

        public static void Register<T>(T controller) where T : class
        {
            _controller[typeof(T)] = controller;
        }

        public static T Get<T>() where T : class
        {
            return _controller[typeof(T)] as T;
        }
    }
}
