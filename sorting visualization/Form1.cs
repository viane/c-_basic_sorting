using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Threading;


namespace sorting_visualization
{
    public partial class SortingVisualization : Form
    {
        public SortingVisualization()
        {
            InitializeComponent();
        }
        Form form_sort;
        List<Label> sortTarget = new List<Label>();
        List<Label> sortTargetCopy = new List<Label>();
        //list to store each label positions.
        List<Point> elementPositionList = new List<Point>();
        int numberofelements = 0, sortCounter=0;
        string bubbleSortCounter="--",InsertionSortCounter="--", SelectionSortCounter = "--"; 
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            Next.Enabled = false;
            BubbleSort.Enabled = false;
            InsertionSort.Enabled = false;
            SelectionSort.Enabled = false;
        }


        private void NumberOfElements_TextChanged(object sender, EventArgs e)
        {
            if(NumberOfElements.Text.Length > 0){
                if (Convert.ToInt32(NumberOfElements.Text) > 1 && Convert.ToInt32(NumberOfElements.Text) <= 25)  //max inputs numbers to sort
                {
                    Next.Enabled = true;
                }
                else
                {

                }
            }
            else
            {
                if (Next.Enabled == true)
                {
                    Next.Enabled = false;
                }
                else
                {

                }
            }
            
        }

        private void Next_Click(object sender, EventArgs e)  //gen input number form
        {
            //delete previous labels from the main form
            for (int x = 0; x < numberofelements; x++)
            {
                foreach (Control c in this.Controls) // clear previous labels,  bug
                {
                    if (c is Label && c.BackColor == Color.Red)
                    {
                        this.Controls.Remove(c);
                    }
                }
            }
            sortTarget.Clear();
            sortTargetCopy.Clear();
            elementPositionList.Clear();
            //elements input list
            numberofelements = Convert.ToInt32(NumberOfElements.Text);
            int totalHeight = 0;
            form_sort = new Form();     
            for(int i = 0; i < numberofelements; i++){
                TextBox txt = new TextBox();
                txt.Name = "element" + (i+1);  //textbox name
                txt.Location = new Point(80, 25 * i + 4);
                form_sort.Controls.Add(txt);
                Label lbl = new Label();
                lbl.Text = "element " + (i + 1) + ": ";
                lbl.Location = new Point(0, 25 * i + 5);
                form_sort.Controls.Add(lbl);
            }         
            totalHeight = (numberofelements+1) * 25 + 80;     
            form_sort.Size = new Size(310, totalHeight);
            Button random = new Button(); //random
            random.Text = "Random";
            random.Location = new Point(150, totalHeight - 75);
            random.Click += new EventHandler(randomFillValue);
            form_sort.Controls.Add(random);
            Button next = new Button();
            next.Text = "Next";
            next.Location = new Point(30, totalHeight -75);
            form_sort.Controls.Add(next);
            next.Click += new EventHandler(next_Click);
            form_sort.ShowDialog();
            this.Refresh();//flushing scrren
        }

        private void next_Click(object sender, EventArgs e)  //gen sorttarget
        {
            Button btnSender = (Button)sender;
            //add label to list
            foreach(Control c  in form_sort.Controls)
            {
                if (c is TextBox)  //create visual bar of element needs to sort
                {
                    Label tempLabel = new Label();
                    tempLabel.BackColor = Color.Red;
                    tempLabel.ForeColor = Color.Yellow;  //check mark color
                    tempLabel.TextAlign = ContentAlignment.MiddleCenter;
                    tempLabel.Height = 15;
                    tempLabel.Width = Convert.ToInt32(c.Text) * 5;
                    sortTarget.Add(tempLabel);
                    sortTargetCopy.Add(tempLabel);  //copy list for reuse;
                }
            }
            form_sort.Close();
            Thread.Sleep(20);
            this.Refresh();//flushing scrren
            //print label to main form
            for (int i = 0; i < sortTarget.Count(); i++)  //list length
            {
                sortTarget[i].Location = new Point(20, (25 * i + 50));
                elementPositionList.Add(sortTarget[i].Location);  //store location
                this.Controls.Add(sortTarget[i]);
                Thread.Sleep(20);
            }
            //disable restore original list until user sort list by any algh
            restoreOldUnsortList.Enabled = false;
            //enable sorting alghs
            BubbleSort.Enabled = true;
            InsertionSort.Enabled = true;
            SelectionSort.Enabled = true;
            sortCounter = 0;
            bubbleSortCounter = "--"; 
            InsertionSortCounter = "--"; 
            SelectionSortCounter = "--";
            SortingCounter.Text = "Sorting Time (in steps) Bubble Sort:   " + bubbleSortCounter + "   Insertion Sort:   " + InsertionSortCounter + "   Selection Sort:   " + SelectionSortCounter;
            this.Refresh();//flushing scrren
        }

        private void randomFillValue(object sender, EventArgs e)
        {
            this.Refresh();//flushing scrren
            Button btnSender = (Button)sender;
            foreach (Control c in form_sort.Controls)
            {
                if (c is TextBox)  //crate visual bar of element needs to sort
                {
                    c.Text = r.Next(1, 100).ToString();
                }
            }
            this.Update();//flushing scrren
        }


        private void bubbleSort()  //sort and change by index and value
        {
            string sortAlghName = "bubbleSort";
            sortCounter = 0;
            while(!isSorted()){
                for (int i = 0; i < sortTarget.Count(); i++)  //clear check mark each run
                {
                    sortTarget[i].Text = "";
                }

                for (int i = 0; i < sortTarget.Count() - 1; i++)  //go through every element in list
                {  
                    
                    if (sortTarget[i].Width > sortTarget[i + 1].Width)  // if current is bigger than next element
                    {  
                        this.Refresh();
                        //move elements
                        //moveRight(i);
                        sortCounter++;  //count how many times
                        visualSwap(i, sortAlghName);
                        //moveLeft(i);
                        //chenge color back

                        this.Refresh();
                    }
                    else
                    {
                        sortTarget[i].Text = "\u221A";  //last check mark
                    }
                    sortTarget[i].BackColor = Color.Red;
                    sortTarget[i + 1].BackColor = Color.Red;
                    sortTarget[i].Text = "\u221A";  //mark checked element
                }
            }
            sortTarget[sortTarget.Count() - 1].Text = "\u221A";  //last check mark
            //enable restore original list
            restoreOldUnsortList.Enabled = true;
            //disable other sorting button until either restore old unsort list or user make new unsort list
            BubbleSort.Enabled = false;
            InsertionSort.Enabled = false;
            SelectionSort.Enabled = false;
        }

        private bool isSorted()
        {
            bool sorted = true;
            int i = 0;
            while (i < sortTarget.Count() - 1 && sorted)
            {
                if(sortTarget[i].Width <= sortTarget[i + 1].Width)
                {
                    sortTarget[i].Text = "\u221A";  //last check mark
                }
                else
                {
                    sorted = false;
                }
                i++;
            }
            return sorted;
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            bubbleSort();
        }



        private void moveRight(int nthElement)
        {
            for (int l = 20; l <= 340; l+=4)  //same Y offset
            {
                sortTarget[nthElement].Location = new Point(l, elementPositionList[nthElement].Y);
                sortTarget[nthElement + 1].Location = new Point(l, elementPositionList[nthElement + 1].Y);
                this.Refresh();
                Thread.Sleep(8); //sleep
            }
        }

        private void visualSwap(int nthElement, string sortAlghName)
        {
            sortTarget[nthElement].BackColor = Color.Blue;
            sortTarget[nthElement + 1].BackColor = Color.Blue;
            Point currentLabelLocation = new Point();
            Point nextLabelLocation = new Point();
            currentLabelLocation = sortTarget[nthElement].Location;  //location var
            nextLabelLocation = sortTarget[nthElement + 1].Location;
            //highlight sawping elements 3 times, if indicator checkbox is checked (by default)
            if (indicator.Checked)
            {
                for (int b = 0; b < 3; b++)
                {
                    sortTarget[nthElement].BackColor = Color.Pink;
                    sortTarget[nthElement + 1].BackColor = Color.Pink;
                    this.Update();
                    Thread.Sleep(400);
                    sortTarget[nthElement].BackColor = Color.Blue;
                    sortTarget[nthElement + 1].BackColor = Color.Blue;
                    this.Update();
                    Thread.Sleep(400);
                }
            }
            for (int y = elementPositionList[nthElement].Y; y <= elementPositionList[nthElement + 1].Y; y++)  //on same X offset
            {
                //swap 2 element visually
                sortTarget[nthElement].Location = new Point(sortTarget[nthElement].Location.X, currentLabelLocation.Y++);
                sortTarget[nthElement + 1].Location = new Point(sortTarget[nthElement + 1].Location.X, nextLabelLocation.Y--);
                this.Refresh();
                Thread.Sleep(4); //sleep
            }
            //swap 2 element in list
            Label tempLabel = new Label();
            tempLabel = sortTarget[nthElement];
            sortTarget[nthElement] = sortTarget[nthElement + 1];
            sortTarget[nthElement + 1] = tempLabel;
            sortTarget[nthElement].BackColor = Color.Red;
            sortTarget[nthElement + 1].BackColor = Color.Red;
            if (sortAlghName == "bubbleSort")
            {
                bubbleSortCounter = sortCounter.ToString();
            }
            else if (sortAlghName == "insertionSort")
            {
                InsertionSortCounter = sortCounter.ToString();
            }else
            {
                SelectionSortCounter = sortCounter.ToString();
            }
            SortingCounter.Text = "Sorting Time (in steps) Bubble Sort:   " + bubbleSortCounter + "   Insertion Sort:   " + InsertionSortCounter + "   Selection Sort:   " + SelectionSortCounter;
            Thread.Sleep(80); //sleep .5 second
        }

        private void moveLeft(int nthElement)
        {
            for (int r = 340; r >= 20; r-=4)  //same Y offset
            {
                sortTarget[nthElement].Location = new Point(r, elementPositionList[nthElement + 1].Y);
                sortTarget[nthElement + 1].Location = new Point(r, elementPositionList[nthElement].Y);
                this.Refresh();
                Thread.Sleep(8); //sleep
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restoreOldUnsortList_Click(object sender, EventArgs e)
        {
            //disable restore original list until user sort list by any algh
            restoreOldUnsortList.Enabled = false;
            //enable sorting alghs
            BubbleSort.Enabled = true;
            InsertionSort.Enabled = true;
            SelectionSort.Enabled = true;
            this.Refresh();//flushing scrren
            //delete previous labels from the main form
            for (int x = 0; x < numberofelements; x++)
            {
                foreach (Control c in this.Controls) // clear previous labels,  bug
                {
                    if (c is Label && c.BackColor == Color.Red)
                    {
                        this.Controls.Remove(c);
                    }
                }
            }
            elementPositionList.Clear();
            for (int i = 0; i < sortTargetCopy.Count(); i++)//reassign old unsort list
            {
                sortTargetCopy[i].Text = "";
                sortTarget[i] = sortTargetCopy[i];
            }
            //reprint labels from original(unsort) list to the main form
            for (int i = 0; i < sortTarget.Count(); i++)  //list length
            {
                sortTarget[i].Location = new Point(20, (25 * i + 50));
                elementPositionList.Add(sortTarget[i].Location);  //store location
                this.Controls.Add(sortTarget[i]);
                Thread.Sleep(20);
            }
            this.Refresh();
        }

        private void SelectionSort_Click(object sender, EventArgs e)
        {
            string sortAlghName = "selectionSort";
        }

        private void InsertionSort_Click_1(object sender, EventArgs e)
        {
            string sortAlghName = "insertionSort";
            sortCounter = 0;
            for (int j = 0; j < sortTarget.Count(); j++)  
            {
                bool sortStarted = false;
                int i = j - 1;
                while (i < sortTarget.Count()-1 && i >= 0)
                {
                    if(sortTarget[i].Width > sortTarget[i + 1].Width){
                        sortCounter++;
                        sortStarted = true;
                        visualSwap(i, sortAlghName);
                        if(i == 0){
                            sortTarget[i].Text = "\u221A";  //mark checked element          ************************************************
                        }                                                                   //       mark funtion is little buggy         //
                        sortTarget[i + 1].Text = "\u221A";  //mark checked element          ************************************************
                        Thread.Sleep(10);
                    }
                    else
                    {
                        sortTarget[i].Text = "\u221A";  //mark checked element
                        Thread.Sleep(10);
                    }
                    i--;
                    Thread.Sleep(10);
                    this.Refresh();
                }
                sortTarget[j].Text = "\u221A";  //mark checked element
            }
            sortTarget[sortTarget.Count() - 1].Text = "\u221A";  //last check mark
            //enable restore original list
            restoreOldUnsortList.Enabled = true;
            //disable other sorting button until either restore old unsort list or user make new unsort list
            BubbleSort.Enabled = false;
            InsertionSort.Enabled = false;
            SelectionSort.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
