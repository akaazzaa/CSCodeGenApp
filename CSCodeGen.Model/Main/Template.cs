using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace CSCodeGen.Model.Main;


public class Template : Observable, INotifyPropertyChanged
{

    #region Variabeln
    private static int nextid = 1;
    private string _name;
    private string _content;
    private string _description;
    #endregion

    #region Properties
    // Readonly 
    [Category("Information")]
    [Description("Dateiname des Templates")]
    public string FileName
    {
        get
        {
            return _name + ".xml";
        }
    }
    // Properties
    [Browsable(false)]
    public string OldName { get; set; }

    [Category("Template")]
    [Description("ID des Templates")]
    public int ID { get; set; }

    [Category("Template")]
    [Description("Name des Templates")]
    public string Name
    {
        get { return _name; }
        set
        {
            if (_name != value)
            {
                if (_name != null)
                {
                    MarkAsChanged();
                }

                OldName = _name;
                _name = value;
                NotifyPropertyChanged();

            }
        }
    }

    [Category("Template")]
    [Description("Beschreibung des Templates")]
    public string Description
    {
        get { return _description; }
        set
        {
            if (_description != value)
            {
                if (_description != null)
                {
                    MarkAsChanged();
                }

                _description = value;
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
    public string Content
    {
        get { return _content; }
        set
        {
            if (_content != value)
            {
                if (_content != null)
                {
                    MarkAsChanged();
                }
                _content = value;
                NotifyPropertyChanged();
            }
        }
    }
    [Category("Template")]
    [Description("Liste der Keywords")]
    public BindingList<Textbaustein> Textbausteine { get; set; }
    public override object _copy { get; set; }

    #endregion

    #region Konstruktoren
    public Template()
    {
        ID = nextid++;
        CreationDate = DateTime.Now;
        Textbausteine = new BindingList<Textbaustein>();
        IsChanged = true;
    }

    public Template(string name)
    {
        Name = name;
        ID = nextid++;
        CreationDate = DateTime.Now;
        Textbausteine = new BindingList<Textbaustein>();
        IsChanged = true;
    }
    #endregion

    #region Events
    public event PropertyChangedEventHandler PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected override void CreateCopy()
    {
        _copy = new Template()
        {
            ID = this.ID,
            Name = this.Name, // Name hinzufügen
            CreationDate = this.CreationDate,
            Description = this.Description,
            Content = this.Content,
            Textbausteine = this.Textbausteine
        };
    }

    protected override void RevertChanges()
    {
        if (_copy is Template originalTemplate)
        {
            this.ID = originalTemplate.ID;
            this.Name = originalTemplate.Name;
            this.Description = originalTemplate.Description;
            this.Content = originalTemplate.Content;
            this.CreationDate = originalTemplate.CreationDate;

            foreach (var textbaustein in this.Textbausteine)
            {
                if (textbaustein.IsChanged)
                {
                    textbaustein.Revert();
                }
            }

            // Benachrichtige über die Änderungen
            NotifyPropertyChanged(nameof(Name));
            NotifyPropertyChanged(nameof(Description));
            NotifyPropertyChanged(nameof(Content));
            NotifyPropertyChanged(nameof(Textbausteine));
            NotifyPropertyChanged(nameof(FileName)); // Falls sich der Name geändert hat
        }
    }

 
    #endregion


}
