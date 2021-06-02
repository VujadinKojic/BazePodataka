using ServerBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string selectedObject = "";
        private ObservableCollection<Radionica> collectionRadionica = new ObservableCollection<Radionica>();
        private ObservableCollection<Eskadrila> collectionEskadrila = new ObservableCollection<Eskadrila>();
        private ObservableCollection<OZL> collectionOZL = new ObservableCollection<OZL>();
        private ObservableCollection<OC> collectionOC = new ObservableCollection<OC>();
        private ObservableCollection<Pilot> collectionPilot = new ObservableCollection<Pilot>();
        private ObservableCollection<Avion> collectionAvion = new ObservableCollection<Avion>();
        private ObservableCollection<AvioTehnicar> collectionAT = new ObservableCollection<AvioTehnicar>();


        public MainWindow()
        {
            InitializeComponent();
        }

        ServiceProvider provider = new ServiceProvider();

        private void Radionica_Click(object sender, RoutedEventArgs e)
        {
            collectionRadionica = provider.GetAllRadionica();
            myDataGrid.ItemsSource = collectionRadionica;
            Block1.Text = " Ime :";
            Block2.Text = " Broj mesta :";
            Block1.Visibility = Visibility.Visible;
            Block2.Visibility = Visibility.Visible;
            Box1.Visibility = Visibility.Visible;
            Box2.Visibility = Visibility.Visible;
            Box1.Text = "";
            Box2.Text = "";
            Block3.Visibility = Visibility.Hidden;
            Block4.Visibility = Visibility.Hidden;
            Block5.Visibility = Visibility.Hidden;
            Combo1.Visibility = Visibility.Hidden;
            Combo2.Visibility = Visibility.Hidden;
            Combo3.Visibility = Visibility.Hidden;
            selectedObject = "Radionica";
        }

        private void AvioTehnicar_Click(object sender, RoutedEventArgs e)
        {
            collectionAT = provider.GetAllAT();
            myDataGrid.ItemsSource = collectionAT;
            Block1.Text = " Ime :";
            Block2.Text = " Broj godina :";
            Block3.Text = " Radionica :";
            Block4.Text = " Eskadrila :";
            Block5.Text = " Specijalnost :";
            Block1.Visibility = Visibility.Visible;
            Block2.Visibility = Visibility.Visible;
            Box1.Visibility = Visibility.Visible;
            Box2.Visibility = Visibility.Visible;
            Box1.Text = "";
            Box2.Text = "";
            Block3.Visibility = Visibility.Visible;
            Block4.Visibility = Visibility.Visible;
            Block5.Visibility = Visibility.Visible;
            Combo1.Visibility = Visibility.Visible;
            Combo2.Visibility = Visibility.Visible;
            Combo3.Visibility = Visibility.Visible;
            selectedObject = "AvioTehnicar";

            Combo1.Items.Clear();
            Combo2.Items.Clear();
            Combo3.Items.Clear();

            Combo1.Items.Add(-1);

            collectionRadionica = provider.GetAllRadionica();
            foreach(var rad in collectionRadionica)
            {
                Combo1.Items.Add(rad.ID_RAD);
            }

            Combo2.Items.Add(-1);

            collectionEskadrila = provider.GetAllEskadrila();
            foreach(var esk in collectionEskadrila)
            {
                Combo2.Items.Add(esk.ID_ESK);
            }

            Combo3.Items.Add(TIP_AT.ElektronskaOprema);
            Combo3.Items.Add(TIP_AT.ElektroOprema);
            Combo3.Items.Add(TIP_AT.VazduhoplovIMotor);


        }

        private void Eskadrila_Click(object sender, RoutedEventArgs e)
        {
            collectionEskadrila = provider.GetAllEskadrila();
            myDataGrid.ItemsSource = collectionEskadrila;
            Block1.Text = " Ime :";
            Block2.Text = " Grb :";
            Block1.Visibility = Visibility.Visible;
            Block2.Visibility = Visibility.Visible;
            Box1.Visibility = Visibility.Visible;
            Box2.Visibility = Visibility.Visible;
            Box1.Text = "";
            Box2.Text = "";
            Block3.Visibility = Visibility.Hidden;
            Block4.Visibility = Visibility.Hidden;
            Block5.Visibility = Visibility.Hidden;
            Combo1.Visibility = Visibility.Hidden;
            Combo2.Visibility = Visibility.Hidden;
            Combo3.Visibility = Visibility.Hidden;
            selectedObject = "Eskadrila";

        }

        private void Avion_Click(object sender, RoutedEventArgs e)
        {
            collectionAvion = provider.GetAllAvion();
            myDataGrid.ItemsSource = collectionAvion;
            Block1.Text = " Snaga :";
            Block2.Text = " Casovi leta :";
            Block3.Text = " Tip :";
            Block1.Visibility = Visibility.Visible;
            Block2.Visibility = Visibility.Visible;
            Box1.Visibility = Visibility.Visible;
            Box2.Visibility = Visibility.Visible;
            Box1.Text = "";
            Box2.Text = "";
            Block3.Visibility = Visibility.Visible;
            Block4.Visibility = Visibility.Hidden;
            Block5.Visibility = Visibility.Hidden;
            Combo1.Visibility = Visibility.Visible;
            Combo2.Visibility = Visibility.Hidden;
            Combo3.Visibility = Visibility.Hidden;
            selectedObject = "Avion";

            Combo1.Items.Clear();
            Combo1.Items.Add(TIP_AV.Lovac);
            Combo1.Items.Add(TIP_AV.Transportni);

        }

        private void Pilot_Click(object sender, RoutedEventArgs e)
        {
            collectionPilot = provider.GetAllPilot();
            myDataGrid.ItemsSource = collectionPilot;
            Block3.Visibility = Visibility.Visible;
            Block4.Visibility = Visibility.Visible;
            Block5.Visibility = Visibility.Visible;
            Block1.Text = " Cin :";
            Block3.Text = " Avion :";
            Block4.Text = " OZL :";
            Block5.Text = " Eskadrila :";
            Block2.Visibility = Visibility.Visible;
            Block2.Visibility = Visibility.Hidden;
            Box1.Visibility = Visibility.Visible;
            Box2.Visibility = Visibility.Visible;
            Box1.Text = "";
            Box2.Visibility = Visibility.Hidden;
            Combo1.Visibility = Visibility.Visible;
            Combo2.Visibility = Visibility.Visible;
            Combo3.Visibility = Visibility.Visible;
            selectedObject = "Pilot";

            Combo1.Items.Clear();
            Combo2.Items.Clear();
            Combo3.Items.Clear();

            collectionAvion = provider.GetAllAvion();
            Combo1.Items.Add(-1);
            foreach(var avion in collectionAvion)
            {
                Combo1.Items.Add(avion.ID_AV);
            }

            collectionOZL = provider.GetAllOZL();
            Combo2.Items.Add(-1);
            foreach (var ozl in collectionOZL)
            {
                Combo2.Items.Add(ozl.ID_OZL);
            }
            collectionEskadrila = provider.GetAllEskadrila();
            Combo3.Items.Add(-1);
            foreach (var esk in collectionEskadrila)
            {
                Combo3.Items.Add(esk.ID_ESK);
            }

        }

        private void OC_Click(object sender, RoutedEventArgs e)
        {
            collectionOC = provider.GetAllOC();
            myDataGrid.ItemsSource = collectionOC;
            Block1.Text = " Broj raketa :";
            Block1.Visibility = Visibility.Visible;
            Block2.Visibility = Visibility.Hidden;
            Box1.Visibility = Visibility.Visible;
            Box1.Text = "";
            Box2.Visibility = Visibility.Hidden;
            Block3.Visibility = Visibility.Hidden;
            Block4.Visibility = Visibility.Hidden;
            Block5.Visibility = Visibility.Hidden;
            Combo1.Visibility = Visibility.Hidden;
            Combo2.Visibility = Visibility.Hidden;
            Combo3.Visibility = Visibility.Hidden;
            selectedObject = "OC";

        }

        private void Ozl_Click(object sender, RoutedEventArgs e)
        {
            collectionOZL = provider.GetAllOZL();
            myDataGrid.ItemsSource = collectionOZL;
            Block1.Text = " Nacelnik :";
            Block2.Text = " Adresa :";
            Block1.Visibility = Visibility.Visible;
            Block2.Visibility = Visibility.Visible;
            Box1.Visibility = Visibility.Visible;
            Box2.Visibility = Visibility.Visible;
            Box1.Text = "";
            Box2.Text = "";
            Block3.Visibility = Visibility.Hidden;
            Block4.Visibility = Visibility.Hidden;
            Block5.Visibility = Visibility.Hidden;
            Combo1.Visibility = Visibility.Hidden;
            Combo2.Visibility = Visibility.Hidden;
            Combo3.Visibility = Visibility.Hidden;
            selectedObject = "OZL";

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (selectedObject == "Radionica")
            {
                if(Box1.Text != null && Box2.Text != null)
                {
                    try
                    {
                        int numberOfSeats = Int32.Parse(Box2.Text);
                        provider.AddRadionica(Box1.Text, numberOfSeats);
                        Box1.Text = "";
                        Box2.Text = "";
                        collectionRadionica = provider.GetAllRadionica();
                        myDataGrid.ItemsSource = collectionRadionica;
                        MessageBox.Show("Uspesno dodato!", "Uspesno ste dodali novu radionicu!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Molimo popunite sva polja ispravno!", "Pogresan broj!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }               
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Nisu sva polja uneta!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedObject == "Eskadrila")
            {
                if (!String.IsNullOrEmpty(Box1.Text) && !String.IsNullOrEmpty(Box2.Text))
                {
                    try
                    {                     
                        provider.AddEskadrila(Box1.Text, Box2.Text);
                        Box1.Text = "";
                        Box2.Text = "";
                        collectionEskadrila = provider.GetAllEskadrila();
                        myDataGrid.ItemsSource = collectionEskadrila;
                        MessageBox.Show("Uspesno dodato!", "Uspesno ste dodali novu eskadrilu!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Molimo popunite sva polja ispravno!", "Pogresan broj!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Nisu sva polja uneta!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedObject == "OZL")
            {
                if (!String.IsNullOrEmpty(Box1.Text) && !String.IsNullOrEmpty(Box2.Text))
                {
                    try
                    {
                        provider.AddOZL(Box1.Text, Box2.Text);
                        Box1.Text = "";
                        Box2.Text = "";
                        collectionOZL = provider.GetAllOZL();
                        myDataGrid.ItemsSource = collectionOZL;
                        MessageBox.Show("Uspesno dodato!", "Uspesno ste dodali novi OZL!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Molimo popunite sva polja ispravno!", "Pogresan broj!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Nisu sva polja uneta!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedObject == "OC")
            {
                if (!String.IsNullOrEmpty(Box1.Text))
                {
                    try
                    {
                        int numberOfRockets = Int32.Parse(Box1.Text);
                        provider.AddOC(numberOfRockets);
                        Box1.Text = "";
                        collectionOC = provider.GetAllOC();
                        myDataGrid.ItemsSource = collectionOC;
                        MessageBox.Show("Uspesno dodato!", "Uspesno ste dodali novi OC!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Molimo popunite sva polja ispravno!", "Pogresan broj!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Nisu sva polja uneta!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedObject == "Pilot")
            {
                if (!String.IsNullOrEmpty(Box1.Text))
                {
                    try
                    {
                        int aviondId = Combo1.SelectedItem == null ? -1 : Int32.Parse(Combo1.SelectedItem.ToString());
                        int ozlId = Combo2.SelectedItem == null ? -1 : Int32.Parse(Combo2.SelectedItem.ToString());
                        int eskadrilaId = Combo3.SelectedItem == null ? -1 : Int32.Parse(Combo3.SelectedItem.ToString());
                        provider.AddPilot(Box1.Text, eskadrilaId, aviondId, ozlId);
                        Box1.Text = "";
                        collectionPilot = provider.GetAllPilot();
                        myDataGrid.ItemsSource = collectionPilot;
                        MessageBox.Show("Uspesno dodato!", "Uspesno ste dodali novog pilota!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Molimo popunite sva polja ispravno!", "Pogresan broj!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Nisu sva polja uneta!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedObject == "Avion")
            {
                if (!String.IsNullOrEmpty(Box1.Text) && !String.IsNullOrEmpty(Box2.Text) && Combo1.SelectedIndex > -1)
                {
                    try
                    {
                        int horsePower = Int32.Parse(Box1.Text);
                        int flightHours = Int32.Parse(Box2.Text);
                        provider.AddAvion(horsePower, flightHours,Combo1.Text);
                        Box1.Text = "";
                        Box2.Text = "";
                        collectionAvion = provider.GetAllAvion();
                        myDataGrid.ItemsSource = collectionAvion;
                        MessageBox.Show("Uspesno dodato!", "Uspesno ste dodali novi avion!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Molimo popunite sva polja ispravno!", "Pogresan broj!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Nisu sva polja uneta!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedObject == "AvioTehnicar")
            {
                if (!String.IsNullOrEmpty(Box1.Text) && !String.IsNullOrEmpty(Box2.Text) && Combo3.SelectedIndex > -1)
                {
                    try
                    {
                        int yearNumber = Int32.Parse(Box2.Text);
                        int radId = Combo1.SelectedItem == null ? -1 : Int32.Parse(Combo1.SelectedItem.ToString());
                        int eskId = Combo2.SelectedItem == null ? -1 : Int32.Parse(Combo2.SelectedItem.ToString());
                        provider.AddAT(Box1.Text, yearNumber, radId, eskId, Combo3.Text);
                        Box1.Text = "";
                        Box2.Text = "";
                        collectionAT = provider.GetAllAT();
                        myDataGrid.ItemsSource = collectionAT;
                        MessageBox.Show("Uspesno dodato!", "Uspesno ste dodali novog avio-tehnicara!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Molimo popunite sva polja ispravno!", "Pogresan broj!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Nisu sva polja uneta!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (selectedObject == "Radionica")
            {
                if (Box1.Text != null && Box2.Text != null)
                {
                    try
                    {
                        int numberOfSeats = Int32.Parse(Box2.Text);
                        Radionica r = (Radionica)myDataGrid.SelectedItem;
                        r.IME_RAD = Box1.Text;
                        r.BM_RAD = numberOfSeats;
                        if(r != null)
                        {
                            provider.UpdateRadionica(r);
                        }
                        Box1.Text = "";
                        Box2.Text = "";
                        collectionRadionica = provider.GetAllRadionica();
                        myDataGrid.ItemsSource = collectionRadionica;
                        MessageBox.Show("Uspesno izmenjeno!", "Uspesno ste izmenili radionicu!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Molimo popunite sva polja ispravno!", "Pogresan broj!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Nisu sva polja uneta!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else if (selectedObject == "Eskadrila")
            {
                if (!String.IsNullOrEmpty(Box1.Text) && !String.IsNullOrEmpty(Box2.Text))
                {
                    try
                    {
                        Eskadrila r = (Eskadrila)myDataGrid.SelectedItem;
                        r.IME_ESK = Box1.Text;
                        r.GRB_ESK = Box2.Text;
                        if (r != null)
                        {
                            provider.UpdateEskadrila(r);
                        }
                        collectionEskadrila = provider.GetAllEskadrila();
                        myDataGrid.ItemsSource = collectionEskadrila;
                        Box1.Text = "";
                        Box2.Text = "";
                        MessageBox.Show("Uspesno izmenjeno!", "Uspesno ste izmenili eskadrilu!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Molimo popunite sva polja ispravno!", "Pogresan broj!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Nisu sva polja uneta!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedObject == "OZL")
            {
                if (!String.IsNullOrEmpty(Box1.Text) && !String.IsNullOrEmpty(Box2.Text))
                {
                    try
                    {
                        OZL r = (OZL)myDataGrid.SelectedItem;
                        r.NO_OZL = Box1.Text;
                        r.ADR_OZL = Box2.Text;
                        if (r != null)
                        {
                            provider.UpdateOZL(r);
                        }
                        collectionOZL = provider.GetAllOZL();
                        myDataGrid.ItemsSource = collectionOZL;
                        Box1.Text = "";
                        Box2.Text = "";
                        MessageBox.Show("Uspesno izmenjeno!", "Uspesno ste izmenili OZL!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Molimo popunite sva polja ispravno!", "Pogresan broj!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Nisu sva polja uneta!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedObject == "OC")
            {
                if (!String.IsNullOrEmpty(Box1.Text))
                {
                    try
                    {
                        OC r = (OC)myDataGrid.SelectedItem;
                        int numberOfRockets = Int32.Parse(Box1.Text);
                        r.BBG_OC = numberOfRockets;
                        if (r != null)
                        {
                            provider.UpdateOC(r);
                        }
                        collectionOC = provider.GetAllOC();
                        myDataGrid.ItemsSource = collectionOC;
                        Box1.Text = "";
                        MessageBox.Show("Uspesno izmenjeno!", "Uspesno ste izmenili OC!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Molimo popunite sva polja ispravno!", "Pogresan broj!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Nisu sva polja uneta!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if(selectedObject == "Pilot")
            {
                if (!String.IsNullOrEmpty(Box1.Text))
                {
                    try
                    {
                        Pilot r = (Pilot)myDataGrid.SelectedItem;
                        r.RN_PIL = Box1.Text;
                        r.AvionID_AV = Combo1.SelectedItem == null ? -1 : Int32.Parse(Combo1.SelectedItem.ToString());
                        r.OZLID_OZL = Combo2.SelectedItem == null ? -1 : Int32.Parse(Combo2.SelectedItem.ToString());
                        r.EskadrilaID_ESK1 = Combo3.SelectedItem == null ? -1 : Int32.Parse(Combo3.SelectedItem.ToString());
                        if (r != null)
                        {
                            provider.UpdatePilot(r);
                        }
                        collectionPilot = provider.GetAllPilot();
                        myDataGrid.ItemsSource = collectionPilot;
                        Box1.Text = "";
                        MessageBox.Show("Uspesno izmenjeno!", "Uspesno ste izmenili Pilota!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Molimo popunite sva polja ispravno!", "Pogresan broj!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Nisu sva polja uneta!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else if (selectedObject == "AvioTehnicar")
            {
                if (!String.IsNullOrEmpty(Box1.Text) && !String.IsNullOrEmpty(Box2.Text) && Combo3.SelectedIndex > -1)
                {
                    try
                    {
                        AvioTehnicar a = (AvioTehnicar)myDataGrid.SelectedItem;
                        int yearNumber = Int32.Parse(Box2.Text);
                        int radId = Combo1.SelectedItem == null ? -1 : Int32.Parse(Combo1.SelectedItem.ToString());
                        int eskId = Combo2.SelectedItem == null ? -1 : Int32.Parse(Combo2.SelectedItem.ToString());

                        a.IME_AT = Box1.Text;
                        a.BG_AT = yearNumber;
                        a.RadionicaID_RAD = radId;
                        a.EskadrilaID_ESK = eskId;
                        if (Combo3.Text == "ElektronskaOprema")
                        {
                            a.TIP_AT = TIP_AT.ElektronskaOprema;
                        }
                        else if (Combo3.Text == "VazduhoplovIMotor")
                        {
                            a.TIP_AT = TIP_AT.VazduhoplovIMotor;
                        }
                        else
                        {
                            a.TIP_AT = TIP_AT.ElektroOprema;
                        }
                        provider.UpdateAT(a);
                        Box1.Text = "";
                        Box2.Text = "";
                        collectionAT = provider.GetAllAT();
                        myDataGrid.ItemsSource = collectionAT;
                        MessageBox.Show("Uspesno dodato!", "Uspesno ste izmenili avio-tehnicara!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Molimo popunite sva polja ispravno!", "Pogresan broj!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Nisu sva polja uneta!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedObject == "Avion")
            {
                if (!String.IsNullOrEmpty(Box1.Text) && !String.IsNullOrEmpty(Box2.Text) && Combo1.SelectedIndex > -1)
                {
                    try
                    {
                        Avion a = (Avion)myDataGrid.SelectedItem;
                        int hp = Int32.Parse(Box1.Text);

                        a.HP_AV = hp;
                        a.BL_AV = Box2.Text;
                        if (Combo3.Text == "Lovac")
                        {
                            a.TIP_AV = TIP_AV.Lovac;
                        }
                        else
                        {
                            a.TIP_AV = TIP_AV.Transportni;
                        }
                        provider.UpdateAvion(a);
                        Box1.Text = "";
                        Box2.Text = "";
                        collectionAvion = provider.GetAllAvion();
                        myDataGrid.ItemsSource = collectionAvion;
                        MessageBox.Show("Uspesno dodato!", "Uspesno ste izmenili avion!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Molimo popunite sva polja ispravno!", "Pogresan broj!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja!", "Nisu sva polja uneta!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (selectedObject == "Radionica")
            {
                if (myDataGrid.SelectedIndex > -1)
                {
                    Box1.Text = "";
                    Box2.Text = "";
                    Radionica r = (Radionica)myDataGrid.SelectedItem;
                    provider.DeleteRadionica(r.ID_RAD);
                    collectionRadionica = provider.GetAllRadionica();
                    myDataGrid.ItemsSource = collectionRadionica;
                }
            }
            else if (selectedObject == "Eskadrila")
            {
                if (myDataGrid.SelectedIndex > -1)
                {
                    Box1.Text = "";
                    Box2.Text = "";
                    Eskadrila r = (Eskadrila)myDataGrid.SelectedItem;
                    provider.DeleteEskadrila(r.ID_ESK);
                    collectionEskadrila = provider.GetAllEskadrila();
                    myDataGrid.ItemsSource = collectionEskadrila;
                }
            }
            else if (selectedObject == "OZL")
            {
                if (myDataGrid.SelectedIndex > -1)
                {
                    Box1.Text = "";
                    Box2.Text = "";
                    OZL r = (OZL)myDataGrid.SelectedItem;
                    provider.DeleteOZL(r.ID_OZL);
                    collectionOZL = provider.GetAllOZL();
                    myDataGrid.ItemsSource = collectionOZL;
                }
            }
            else if (selectedObject == "OC")
            {
                if (myDataGrid.SelectedIndex > -1)
                {
                    Box1.Text = "";
                    OC r = (OC)myDataGrid.SelectedItem;
                    provider.DeleteOC(r.ID_OC);
                    collectionOC = provider.GetAllOC();
                    myDataGrid.ItemsSource = collectionOC;
                }
            }
            else if (selectedObject == "Pilot")
            {
                if (myDataGrid.SelectedIndex > -1)
                {
                    Box1.Text = "";
                    Pilot r = (Pilot)myDataGrid.SelectedItem;
                    provider.DeletePilot(r.ID_PIL);
                    collectionPilot = provider.GetAllPilot();
                    myDataGrid.ItemsSource = collectionPilot;
                }
            }
            else if (selectedObject == "Avion")
            {
                if (myDataGrid.SelectedIndex > -1)
                {
                    Box1.Text = "";
                    Box1.Text = "";
                    Avion r = (Avion)myDataGrid.SelectedItem;
                    provider.DeleteAvion(r.ID_AV);
                    collectionAvion = provider.GetAllAvion();
                    myDataGrid.ItemsSource = collectionAvion;
                }
            }
            else if (selectedObject == "AvioTehnicar")
            {
                if (myDataGrid.SelectedIndex > -1)
                {
                    Box1.Text = "";
                    Box2.Text = "";
                    AvioTehnicar r = (AvioTehnicar)myDataGrid.SelectedItem;
                    provider.DeleteAT(r.ID_AT);
                    collectionAT = provider.GetAllAT();
                    myDataGrid.ItemsSource = collectionAT;
                }
            }
        }

        private void myDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if(selectedObject == "Radionica")
                {
                    Radionica r = (Radionica)myDataGrid.SelectedItem;
                    Box1.Text = r.IME_RAD;
                    Box2.Text = r.BM_RAD.ToString();
                }
                else if (selectedObject == "Eskadrila")
                {
                    Eskadrila r = (Eskadrila)myDataGrid.SelectedItem;
                    Box1.Text = r.IME_ESK;
                    Box2.Text = r.GRB_ESK;
                }
                else if (selectedObject == "OZL")
                {
                    OZL r = (OZL)myDataGrid.SelectedItem;
                    Box1.Text = r.NO_OZL;
                    Box2.Text = r.ADR_OZL;
                }
                else if (selectedObject == "OC")
                {
                    OC r = (OC)myDataGrid.SelectedItem;
                    Box1.Text = r.BBG_OC.ToString();
                }
                else if(selectedObject == "Pilot")
                {
                    Pilot r = (Pilot)myDataGrid.SelectedItem;
                    Box1.Text = r.RN_PIL;
                    Combo1.SelectedItem = r.AvionID_AV;
                    Combo2.SelectedItem = r.OZLID_OZL;
                    Combo3.SelectedItem = r.EskadrilaID_ESK1;
                }
                else if (selectedObject == "AvioTehnicar")
                {
                    AvioTehnicar r = (AvioTehnicar)myDataGrid.SelectedItem;
                    Box1.Text = r.IME_AT;
                    Box2.Text = r.BG_AT.ToString();
                    Combo1.SelectedItem = r.RadionicaID_RAD;
                    Combo2.SelectedItem = r.EskadrilaID_ESK;
                    Combo3.SelectedItem = r.TIP_AT;
                }
                else if (selectedObject == "Avion")
                {
                    Avion r = (Avion)myDataGrid.SelectedItem;
                    Box1.Text = r.HP_AV.ToString();
                    Box2.Text = r.BL_AV;
                    Combo1.SelectedItem = r.TIP_AV;
                }

            }
            catch
            {

            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Box1.Visibility = Visibility.Hidden;
            Box2.Visibility = Visibility.Hidden;
            Combo1.Visibility = Visibility.Hidden;
            Combo2.Visibility = Visibility.Hidden;
            Combo3.Visibility = Visibility.Hidden;
        }

        private void ButtonRemont_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BlockRemont.Text = " " + (provider.P_AIRPLANE_Remont(Int32.Parse(BoxRemont.Text))).ToString();
            }
            catch
            {

            }
        }

        private void DodajRadionicu_Click(object sender, RoutedEventArgs e)
        {
            provider.P_INS_Radionica();

            if (selectedObject == "Radionica")
            {
                collectionRadionica = provider.GetAllRadionica();
                myDataGrid.ItemsSource = collectionRadionica;
            }
        }

        private void ButtonPilot_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BlockPilot.Text = " ID:" + provider.F_BEST_PILOT().ToString();
            }
            catch
            {

            }
        }

        private void ButtonLovac_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BlockLovac.Text = " " + provider.F_LOVAC_NUMBER().ToString();
            }
            catch
            {

            }
        }
    }
}
