﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSCodeGen.Model.Main;


public class CodeTemplate : Observable, INotifyPropertyChanged
{

    #region Variabeln
    private static int nextid = 1;
    private string _Name;
    private string _Source;
    private string _Description;
    private string _Filename;
    #endregion

    #region Properties
    // Readonly 
    [Category("Information")]
    [Description("Dateiname des Templates")]
    public string FileName
    {
        get
        {
            return _Name + ".xml";
        }
    }
    // Properties
    [Browsable(false)]
    public string OldName { get; set; }

    [Category("Template")]
    [Description("ID des Templates")]
    public int ID { get; }

    [Category("Template")]
    [Description("Name des Templates")]
    public string Name
    {
        get { return _Name; }
        set
        {
            if (_Name != value)
            {
                if (_Name != null)
                {
                    MarkAsChanged();
                }

                OldName = _Name;
                _Name = value;
                NotifyPropertyChanged();

            }
        }
    }

    [Category("Template")]
    [Description("Beschreibung des Templates")]
    public string Description
    {
        get { return _Description; }
        set
        {
            if (_Description != value)
            {
                if (_Description != null)
                {
                    MarkAsChanged();
                }

                _Description = value;
                NotifyPropertyChanged();

            }
        }
    }

    [ReadOnly(true)]
    [Category("Information")]
    [Description("Anlagedatum des Templates")]
    public DateTime CreationDate { get; set; }
    [ReadOnly(true)]
    [Category("Information")]
    [Description("Quellcode des Templates")]
    public string Source
    {
        get { return _Source; }
        set
        {
            if (_Source != value)
            {
                if (_Source != null)
                {
                    MarkAsChanged();
                }

                _Source = value;
                NotifyPropertyChanged();

            }
        }
    }

    [Category("Template")]
    [Description("Liste der Keywords")]
    public BindingList<Keyword> Keywords { get; set; }
    #endregion

    #region Konstruktoren
    public CodeTemplate()
    {
        ID = nextid++;
        CreationDate = DateTime.Now;
        Keywords = new BindingList<Keyword>();
        IsChanged = true;
    }

    public CodeTemplate(string name)
    {
        Name = name;
        ID = nextid++;
        CreationDate = DateTime.Now;
        Keywords = new BindingList<Keyword>();
        IsChanged = true;
    }
    #endregion

    #region Events
    public event PropertyChangedEventHandler PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion
}
