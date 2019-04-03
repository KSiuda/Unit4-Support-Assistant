using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Unit4HomeOffice.Entities;
using System.Text;

namespace Unit4HomeOffice.Classes
{
    public class ExcelImport
    {

        public void Import(Context context, string path)
        {
            //@"C:\Users\KSIUDA\Desktop\SQL\Training List.xlsx"
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            var trainings = new List<Tuple<int, string>>();
            var consultants = new List<Tuple<int, string>>();
            var blanks = new List<int>();

            for (int row = 3; row <= rowCount; row++)
            {
                string training = "";
                string instructor = "";
                string duration = "";
                string type = "";

                for (int column = 2; column < 8; column++)
                {

                    if (column == 2)
                    {
                        if (xlRange.Cells[row, column] != null && xlRange.Cells[row, column].Value2 != null)
                        {

                            string value = xlRange.Cells[row, column].Value2.ToString();
                            if (value.ToUpper() != value)
                            {
                                training = value;
                            }
                            else if (value.ToUpper() == value && value.Length < 7)
                            {
                                training = value;
                            }
                            else
                            {
                                blanks.Add(row);
                            }

                        }

                    }

                    if (column == 3)
                    {

                        if (xlRange.Cells[row, column] != null && xlRange.Cells[row, column].Value2 != null)
                        {
                            string value = xlRange.Cells[row, column].Value2.ToString();

                            if (value.ToUpper() != value)
                            {
                                type = value;
                            }

                        }

                    }

                    if (column == 6)
                    {

                        if (xlRange.Cells[row, column] != null && xlRange.Cells[row, column].Value2 != null)
                        {
                            string value = xlRange.Cells[row, column].Value2.ToString();

                            if (value.ToUpper() != value)
                            {
                                instructor = value;
                            }

                        }

                    }

                    if (column == 7)
                    {

                        if (xlRange.Cells[row, column] != null && xlRange.Cells[row, column].Value2 != null)
                        {
                            string value = xlRange.Cells[row, column].Value2.ToString();

                            duration = value;

                        }
                    }


                }

                if (instructor != "" || training != "")
                {
                    if (instructor == "")
                    {
                        instructor = "None";
                    }
                    if (duration == "")
                    {
                        duration = null;
                    }
                    Int32.TryParse(duration, out int dur);

                    trainings.Add(Tuple.Create(trainings.Count() + 1, training));
                    var Training = new Trainings
                    {
                        Name = training,
                        Type = type,
                        Trainer = instructor,
                        Duration = dur,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now


                    };
                    context.Trainings.Add(Training);
                    context.SaveChanges();

                }
            }




            for (int row = 1; row <= 1; row++)
            {
                string consultant = "";

                for (int column = 10; column <= colCount; column++)
                {
                    string value = xlRange.Cells[row, column].Value2.ToString();

                    consultant = value;
                    consultants.Add(Tuple.Create(consultants.Count() + 1, consultant));
                    var Consultant = new Consultants
                    {
                        Name = consultant,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now

                    };
                    context.Consultants.Add(Consultant);
                    context.SaveChanges();
                }

            }


            foreach (var consultant in consultants)
            {
                int blank = 0;
                int id;
                for (int row = 3; row <= trainings.Count() + 2 + blanks.Count(); row++)
                {
                    string trainingState = "";
                    int counter = row - 2;

                    for (int column = 10 + consultant.Item1 - 1; column < 10 + consultant.Item1; column++)
                    {
                        if (xlRange.Cells[row, column] != null && xlRange.Cells[row, column].Value2 != null)
                        {

                            string value = xlRange.Cells[row, column].Value2.ToString();

                            trainingState = value;
                            if (trainingState == "")
                            {
                                blank++;
                            }
                            else
                            {
                                id = counter - blank;
                                var query = trainings.AsEnumerable();
                                var trainigname = from train in query
                                                  where train.Item1 == id
                                                  select train.Item2;

                                string name = String.Join("", trainigname);


                                var TrainingDetails = new TrainingDetails
                                {

                                    TrainingName = name,
                                    ConsultantName = consultant.Item2,
                                    Status = trainingState,
                                    CreatedDate = DateTime.Now,
                                    ModifiedDate = DateTime.Now

                                };
                                context.TrainingDetails.Add(TrainingDetails);
                                context.SaveChanges();
                            }

                        }
                        else
                        {
                            blank++;
                        }
                    }

                }
            }
        }
        public List<Tuple<string, int>> CheckConsultants(string path)       
        {
                //Create COM Objects. Create a COM object for everything that is referenced
                Excel.Application xlApp = new Excel.Application();
                //Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(url);
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
                Excel._Worksheet xlWorksheet = xlWorkbook.Worksheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;
                List<Tuple<string, int>> Consultants = new List<Tuple<string, int>>();

            try
            {
                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;


                //iterate over the rows and columns and print to the console as it appears in the file
                //excel is not zero based!!
                //GET DAY
                int columnDay = 0;
                var day = DateTime.Now.Day.ToString();
                int consultantsCount = 28;

                columnDay = 6 + Convert.ToInt16(day);
                for (int row = 5; row <= consultantsCount; row++)
                {
                    string name = "";
                    int cases = 0;

                    for (int column = 3; column <= 3; column++)
                    {

                        if (xlRange.Cells[row, column] != null && xlRange.Cells[row, column].Value2 != null)
                        {
                            string value = xlRange.Cells[row, column].Value2.ToString();
                            name = value;
                        }


                    }
                    for (int column = columnDay; column <= columnDay; column++)
                    {
                        if (xlRange.Cells[row, column] != null && xlRange.Cells[row, column].Value2 != null)
                        {
                            string value = xlRange.Cells[row, column].Value2.ToString();
                            if (value.Contains("x"))
                            {
                                value = "9";
                            }
                            cases = Convert.ToInt16(value);
                        }

                    }
                    Consultants.Add(Tuple.Create(name, cases));
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:
                //  never use two dots, all COM objects must be referenced and released individually
                //  ex: [somthing].[something].[something] is bad

                //release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp); 
            }

                return Consultants;
            }

        }
    }
           

