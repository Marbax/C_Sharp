using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApartmentLib;
using ClientLib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ApartmentCRM
{
    class DataManager
    {
        private BinaryFormatter bf = new BinaryFormatter();

        private string _clientsFilePath;

        public string ClientsFilePath
        {
            get { return _clientsFilePath; }
            set { _clientsFilePath = value; }
        }

        private string _apartmentsFilePath;

        public string ApartmentsFilePath
        {
            get { return _apartmentsFilePath; }
            set { _apartmentsFilePath = value; }
        }

        private List<Client> _clientsData;

        public List<Client> ClientsData
        {
            get { return _clientsData; }
            set { _clientsData = value; }
        }

        private List<Apartment> _apartmentsData;

        public List<Apartment> ApartmentsData
        {
            get { return _apartmentsData; }
            set { _apartmentsData = value; }
        }

        public DataManager(string clientsFilePath = @"..\..\Data\clients.dat", string apartmentsFilePath = @"..\..\Data\apartments.dat")
        {
            _clientsFilePath = clientsFilePath;
            _apartmentsFilePath = apartmentsFilePath;
            _clientsData = new List<Client>();
            _apartmentsData = new List<Apartment>();
            InitData();
        }

        private void InitData()
        {
            List<string> tmp_photo = new List<string>();
            tmp_photo.Add(@"..\..\img\1.jpg");
            tmp_photo.Add(@"..\..\img\2.jpg");
            tmp_photo.Add(@"..\..\img\3.jpg");

            for (int i = 0; i < 10; i++)
            {
                ApartmentsData.Add(new Apartment($"Apartment-{i}", $"Description-{i}", i * 200.2,
                    new DateTime(2010, 2, 1), new DateTime(2010, 2, 4),tmp_photo.ToArray()));
                ClientsData.Add(new Client($"Client-{i}", $"3809{i}3{i + 1}2{i + 2}",ApartmentsData.ToArray()));
            }
        }

        private void SaveData()
        {
            try
            {
                SaveClients();
                SaveApartments();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SaveClients()
        {
            try
            {
                using (FileStream fs = new FileStream(_clientsFilePath, FileMode.Create))
                {
                    bf.Serialize(fs, _clientsData);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void SaveApartments()
        {
            try
            {
                using (FileStream fs = new FileStream(_apartmentsFilePath, FileMode.Create))
                {
                    bf.Serialize(fs, _apartmentsData);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LoadData()
        {
            try
            {
                LoadClients();
                LoadApartments();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadClients()
        {
            try
            {
                using (FileStream fs = new FileStream(_clientsFilePath, FileMode.Open))
                {
                    _clientsData = (List<Client>)bf.Deserialize(fs);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void LoadApartments()
        {
            try
            {
                using (FileStream fs = new FileStream(_apartmentsFilePath, FileMode.Open))
                {
                    _apartmentsData = (List<Apartment>)bf.Deserialize(fs);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
