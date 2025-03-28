﻿using 
using System.ComponentModel;

namespace CSCodeGen.Contracts.Interfaces
{
     public interface ICodeTemplateView<T> 
    {
        
        void ShowTemplates(BindingList<T> templates);
        void ShowMessage(string message);
        event EventHandler LoadTemplates;
        event EventHandler<TemplateEventArgs> SaveTemplate;
        event EventHandler<TemplateEventArgs> NewTemplate;
        event EventHandler<TemplateEventArgs> AddKeyword;
        event EventHandler<TemplateEventArgs> RemoveKeyword;

    }
}
