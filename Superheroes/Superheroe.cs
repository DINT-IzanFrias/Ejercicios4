using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

class Superheroe : INotifyPropertyChanged
    {
    private string nombre;
    public string Nombre
    {
        get { return this.nombre; }
            set
            {
                if (this.nombre != value)
                {
                    this.nombre = value;
                    NotifyPropertyChanged("Nombre");
                }
            }
    }
    private string imagen;
    public string Imagen
    {
        get { return this.imagen; }
        set
        {
            if (this.imagen != value)
            {
                this.imagen = value;
                NotifyPropertyChanged("Imagen");
            }
        }
    }
    private bool vengador;
    public bool Vengador
    {
        get { return this.vengador; }
        set
        {
            if (this.vengador != value)
            {
                this.vengador = value;
                NotifyPropertyChanged("Vengador");
            }
        }
    }
    private bool xmen;
    public bool Xmen
    {
        get { return this.xmen; }
        set
        {
            if (this.xmen != value)
            {
                this.xmen = value;
                NotifyPropertyChanged("Xmen");
            }
        }
    }
    private bool heroe;
    public bool Heroe
    {
        get { return this.heroe; }
        set
        {
            if (this.heroe != value)
            {
                this.heroe = value;
                NotifyPropertyChanged("Heroe");
            }
        }
    }
    private bool villano;
    public bool Villano
    {
        get { return this.villano; }
        set
        {
            if (this.villano != value)
            {
                this.villano = value;
                NotifyPropertyChanged("Villano");
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void NotifyPropertyChanged(string propertyName)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }


    public Superheroe(){}

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe, bool villano)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
            Villano = villano;
        }

        public static List<Superheroe> GetSamples()
        {
            List<Superheroe> ejemplos = new List<Superheroe>();

            Superheroe ironman = new Superheroe("Ironman", @"https://dossierinteractivo.com/wp-content/uploads/2021/01/Iron-Man.png",true, false,true, false);
            Superheroe kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false,false, true);
            Superheroe spiderman = new Superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true,true, false);
            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);
            return ejemplos;
        }
 }