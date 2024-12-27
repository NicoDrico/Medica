using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Medica.Model;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Automation.Peers;
using Npgsql;
using Medica.Model.Models;

namespace Medica
{
    internal class DB
    {
        public string connection = "Host=localhost;Port=5432;Database=Medic;Username=postgres;Password=1;";
        public List<Employee> getAllEmployees()
        {
            using (var connection = new NpgsqlConnection(this.connection))
            {
                connection.Open();
                string query = "SELECT * FROM employees";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@Login", login);
                    using (var reader = command.ExecuteReader())
                    {
                        List<Employee> employees = new List<Employee>();

                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                Id = Convert.ToInt32(reader["id"].ToString()),
                                FirstName = reader["FirstName"].ToString(),
                                MiddleName = reader["MiddleName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Email = reader["Email"].ToString(),
                            };

                            // Add the row to the list
                            employees.Add(employee);
                        }

                        return employees;
                    }
                }
            }
        }


        //Удаление
        public void deleteEmployees(int id)
        {
            string query = "DELETE FROM employees WHERE id=@id";

            using (var connection = new NpgsqlConnection(this.connection))
            {
                var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
                
            }
        }
        //Добавление
        public void addEmployees(string firstName, string middleName, string lastName, string phoneNumber, string email)
        {
            string query = "INSERT INTO employees (firstName, middleName, lastName, phoneNumber, email) VALUES (@FirstName, @MiddleName, @LastName, @PhoneNumber, @Email)";

            using (var connection = new NpgsqlConnection(this.connection))
            {
                var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@MiddleName", middleName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Email", email);


                connection.Open();
                command.ExecuteNonQuery();
            }

        }
    
        //  Equipment
        public List<Equipment> getAllEquipments()
        {
            using (var connection = new NpgsqlConnection(this.connection))
            {
                connection.Open();
                string query = "SELECT * FROM equipment";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@Login", login);
                    using (var reader = command.ExecuteReader())
                    {
                        List<Equipment> equipments = new List<Equipment>();

                        while (reader.Read())
                        {
                            Equipment equipment = new Equipment
                            {
                                Id = Convert.ToInt32(reader["id"].ToString()),
                                Name = reader["Name"].ToString(),
                                Description = reader["Description"].ToString(),
                               
                               
                            };

                            // Add the row to the list
                            equipments.Add(equipment);
                        }

                        return equipments;
                    }
                }
            }
        }


        //Удаление
        public void deleteEquipment(int id)
        {
            string query = "DELETE FROM equipment WHERE id=@id";

            using (var connection = new NpgsqlConnection(this.connection))
            {
                var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        //Добавление
        public void addEquipment(string name, string description)
        {
            string query = "INSERT INTO equipment (name, description) VALUES (@Name, @Description)";

            using (var connection = new NpgsqlConnection(this.connection))
            {
                var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", description);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }  
    
        //Medication
        public List<Medication> getAllMedications()
        {
            using (var connection = new NpgsqlConnection(this.connection))
            {
                connection.Open();
                string query = "SELECT * FROM medications";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@Login", login);
                    using (var reader = command.ExecuteReader())
                    {
                        List<Medication> medications = new List<Medication>();

                        while (reader.Read())
                        {
                            Medication medication = new Medication
                            {
                                Id = Convert.ToInt32(reader["id"].ToString()),
                                Name = reader["Name"].ToString(),
                                Category = reader["Category"].ToString(),
                                ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"].ToString()),
                                Quantity = Convert.ToInt32(reader["Quantity"].ToString()),
                                ProviderId = Convert.ToInt32(reader["ProviderId"].ToString()),


                            };

                            // Add the row to the list
                            medications.Add(medication);
                        }

                        return medications;
                    }
                }
            }
        }


        //Удаление
        public void deleteMedication(int id)
        {
            string query = "DELETE FROM medications WHERE id=@id";

            using (var connection = new NpgsqlConnection(this.connection))
            {
                var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        //Добавление
        public void addMedication(string name, string category, string expirationDate,string quantity, string providerId)
        {
            string query = "INSERT INTO medications (name, category, expirationDate, quantity, providerId) VALUES (@Name, @Category, @ExpirationDate, @Quantity, @Provider)";

            using (var connection = new NpgsqlConnection(this.connection))
            {
                var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@Provider", providerId);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }  
    

        //Orders_Medications
        public List<OrderMedication> getAllOrdersMedications()
        {
            using (var connection = new NpgsqlConnection(this.connection))
            {
                connection.Open();
                string query = "SELECT * FROM orders_medications";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@Login", login);
                    using (var reader = command.ExecuteReader())
                    {
                        List<OrderMedication> orderMedications = new List<OrderMedication>();

                        while (reader.Read())
                        {
                            OrderMedication orderMedication = new OrderMedication
                            {
                                Id = Convert.ToInt32(reader["id"].ToString()),
                                OrderDate = Convert.ToDateTime(reader["ExpirationDate"].ToString()),
                                MedicationId = Convert.ToInt32(reader["MedicationId"].ToString()),
                                Quantity = Convert.ToInt32(reader["Quantity"].ToString()),
                                ProviderId = Convert.ToInt32(reader["ProviderId"].ToString()),
                                Status = reader["Status"].ToString()

                            };

                            // Add the row to the list
                            orderMedications.Add(orderMedication);
                        }

                        return orderMedications;
                    }
                }
            }
        }


        //Удаление
        public void deleteOrderMedication(int id)
        {
            string query = "DELETE FROM orders_medications WHERE id=@id";

            using (var connection = new NpgsqlConnection(this.connection))
            {
                var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        //Добавление
        public void addOrderMedication(string orderDate, string medicationId, string quantity, string providerId, string status)
        {
            string query = "INSERT INTO orders_medications (orderDate, medicationId, quantity, providerId, status) VALUES (@OrderDate, @MedicationId, @Quantity, @Provider, @Status)";

            using (var connection = new NpgsqlConnection(this.connection))
            {
                var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderDate", orderDate);
                command.Parameters.AddWithValue("@MedicationId", medicationId);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@Provider", providerId);
                command.Parameters.AddWithValue("@Status", status);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }  
    
        //Order_Equipments
        public List<OrderEquipment> getAllOrderEquipments()
        {
            using (var connection = new NpgsqlConnection(this.connection))
            {
                connection.Open();
                string query = "SELECT * FROM orders_equipment";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@Login", login);
                    using (var reader = command.ExecuteReader())
                    {
                        List<OrderEquipment> orderEquipments = new List<OrderEquipment>();

                        while (reader.Read())
                        {
                            OrderEquipment orderEquipment = new OrderEquipment
                            {
                                Id = Convert.ToInt32(reader["id"].ToString()),
                                OrderDate = Convert.ToDateTime(reader["OrderDate"].ToString()),
                                EquipmentId = Convert.ToInt32(reader["EquipmentId"].ToString()),
                                Quantity = Convert.ToInt32(reader["Quantity"].ToString()),
                                ProviderId = Convert.ToInt32(reader["ProviderId"].ToString()),
                                Status = reader["Status"].ToString(),
                            };

                            // Add the row to the list
                            orderEquipments.Add(orderEquipment);
                        }

                        return orderEquipments;
                    }
                }
            }
        }


        //Удаление
        public void deleteOrderEquipments(int id)
        {
            string query = "DELETE FROM orders_equipment WHERE id=@id";

            using (var connection = new NpgsqlConnection(this.connection))
            {
                var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        //Добавление
        public void addOrderEquipments(string orderDate, string equipment, string quantity, string providerId, string status)
        {
            string query = "INSERT INTO orders_equipment (orderDate, equipment, quantity, providerId, status) VALUES (@OrderDate, @Equipment, @Quantity, @ProviderId, @Status)";

            using (var connection = new NpgsqlConnection(this.connection))
            {
                var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderDate", orderDate);
                command.Parameters.AddWithValue("@Equipment", equipment);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@ProviderId", providerId);
                command.Parameters.AddWithValue("@Status", status);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }  
    
        //Provider
        public List<Provider> getAllProviders()
        {
            using (var connection = new NpgsqlConnection(this.connection))
            {
                connection.Open();
                string query = "SELECT * FROM provider";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@Login", login);
                    using (var reader = command.ExecuteReader())
                    {
                        List<Provider> providers = new List<Provider>();

                        while (reader.Read())
                        {
                            Provider provider = new Provider
                            {
                                Id = Convert.ToInt32(reader["id"].ToString()),
                                Name = reader["Name"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Address = reader["Address"].ToString(),


                            };

                            // Add the row to the list
                            providers.Add(provider);
                        }

                        return providers;
                    }
                }
            }
        }


        //Удаление
        public void deleteProviders(int id)
        {
            string query = "DELETE FROM provider WHERE id=@id";

            using (var connection = new NpgsqlConnection(this.connection))
            {
                var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        //Добавление
        public void addProviders(string name, string phoneNumber, string address)
        {
            string query = "INSERT INTO provider (name, phoneNumber, Address) VALUES (@Name, @PhoneNumber, @Address)";

            using (var connection = new NpgsqlConnection(this.connection))
            {
                var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Address", address);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }  
    }
}