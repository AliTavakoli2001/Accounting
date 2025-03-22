using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Accounting.Utility.Report
{
    public class Print

    {
        public bool havePageNumber { get; set; } = true;
        public string titleText { get; set; } = "";
        public string[] deletedColumns { get; set; } = { };

        private System.Drawing.Printing.PrintPageEventArgs e;

        public Print(System.Drawing.Printing.PrintPageEventArgs printEvent, DataGridView DGView)
        {
            e = printEvent;
            dataGridView = DGView;
        }
        private DataGridView _dataGridView;

        public DataGridView dataGridView
        {
            get
            {
                return _dataGridView;
            }
            private set
            {
                _dataGridView = MakeDataGridViewReverse(value);
                _dataGridView.Font = value.Font;
            }
        }

        private int currentPage = 1;

        private DataGridView MakeDataGridViewReverse(DataGridView dataGridView)
        {
            int dataGridViewColNum = dataGridView.Columns.Count;
            DataGridView newDGV = new DataGridView();
            for (int i = dataGridViewColNum - 1; i >= 0; i--)
            {
                newDGV.Columns.Add((DataGridViewColumn)dataGridView.Columns[i].Clone());
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                    for (int i = 0; i < row.Cells.Count; i++)
                        newRow.Cells[dataGridViewColNum - 1 - i].Value = row.Cells[i].Value;
                    newDGV.Rows.Add(newRow);
                }
            }
            return newDGV;
        }
        public void PrintConfiguration()
        {
            int height = 0;
            int width = 0;
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top + ((titleText != "") ? 50 : 0);

            Font titleFont = new Font("B Titr", 18);
            string Title = titleText;
            SizeF titleSize = e.Graphics.MeasureString(Title, titleFont);

            e.Graphics.DrawString(Title, titleFont, Brushes.Black,
                new PointF(e.MarginBounds.Left + (e.MarginBounds.Width - titleSize.Width) / 2, e.MarginBounds.Top));

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            foreach (DataGridViewColumn column in dataGridView.Columns)
                if (column.Visible && !deletedColumns.Contains(column.Name))
                    width += column.Width;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (deletedColumns.Contains(column.Name) || !column.Visible)
                    continue;

                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y, column.Width, dataGridView.ColumnHeadersHeight));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, column.Width, dataGridView.ColumnHeadersHeight));
                e.Graphics.DrawString(column.HeaderText, dataGridView.Font, Brushes.Black,
                    new RectangleF(x, y, column.Width, dataGridView.ColumnHeadersHeight), stringFormat);
                x += column.Width;
            }

            stringFormat.Alignment = StringAlignment.Far;

            y += dataGridView.ColumnHeadersHeight;
            x = e.MarginBounds.Left;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow)
                    continue;

                height = row.Height;
                x = e.MarginBounds.Left;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!cell.OwningColumn.Visible || deletedColumns.Contains(cell.OwningColumn.Name)) continue;

                    Rectangle cellBounds = new Rectangle(x, y, cell.OwningColumn.Width, height);
                    e.Graphics.DrawRectangle(Pens.Black, cellBounds);

                    string cellValue = (cell.Value != null) ? cell.Value.ToString() : "";

                    e.Graphics.DrawString(cellValue, dataGridView.Font, Brushes.Black, cellBounds, stringFormat);
                    x += cell.OwningColumn.Width;
                }

                y += height;

                if (y + height > e.MarginBounds.Bottom - 50)
                {
                    e.HasMorePages = true;
                    currentPage++;
                    return;
                }
            }

            if (havePageNumber)
            {
                string pageText = $"صفحه {currentPage}";
                Font pageFont = new Font("B Nazanin", 12);
                SizeF pageSize = e.Graphics.MeasureString(pageText, pageFont);
                e.Graphics.DrawString(pageText, pageFont, Brushes.Black,
                    new PointF(e.MarginBounds.Left + (e.MarginBounds.Width - pageSize.Width) / 2, e.MarginBounds.Bottom - 30));
            }
            currentPage = 1;
        }
    }
}
