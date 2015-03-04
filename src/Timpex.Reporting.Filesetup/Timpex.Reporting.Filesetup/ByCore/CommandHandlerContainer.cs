using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Timpex.Reporting.Filesetup.ByCore
{
    public class CommandHandlerContainer
    {
        private static readonly CommandHandlerContainer Instance = new CommandHandlerContainer();
        public static Func<CommandHandlerContainer> New = () => Instance;
        private readonly Dictionary<string, Type> Dictionary = new Dictionary<string, Type>();
        private readonly Dictionary<Type, Type> TypeDictionary = new Dictionary<Type, Type>();

        public virtual void RegisterStartpoint<TStartpoint>(string command) where TStartpoint : StartPoint
        {
            if (!Dictionary.ContainsKey(command) && !TypeDictionary.ContainsKey(typeof(TStartpoint)))
            {
                Dictionary.Add(command, typeof (TStartpoint));
                TypeDictionary.Add(typeof (TStartpoint), typeof (TStartpoint));
            }
        }

        public virtual StartPoint ResolveFor(string command)
        {
            if (!Dictionary.ContainsKey(command))
                return null;
            var startpoint = Dictionary[command];
            return (StartPoint)Activator.CreateInstance(startpoint);
        }

        public virtual StartPoint Resolve<TStartPoint>() where TStartPoint : StartPoint
        {
            return (StartPoint) Activator.CreateInstance(TypeDictionary[typeof (TStartPoint)]);
        }
    }
}