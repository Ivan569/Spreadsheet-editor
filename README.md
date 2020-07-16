# Назначение проекта

# Conditions
In older text editors, tables were drawn using pseudographic characters. At the same time, some text editors could create a table, but did not allow editing it.in other words, after changing the text in cells, you have to manually redraw the entire table to restore the layout of rows and columns. You are asked to implement an editor fragment that performs table formatting.

The table is a rectangle divided into cells by vertical ( | ) and horizontal ( - ) lines connecting the rectangle's borders. At the intersection of the vertical and horizontal lines, the + sign is placed.the rectangle Borders are also formed by the |, - and + symbols, and the +symbols are placed in the corners of the original rectangle.

Text inside table cells can be placed on multiple rows. The text consists only of Latin uppercase and lowercase letters, numbers, and punctuation marks (with the exception of the-sign).

When editing a table, the text of cells changes, so the | characters may be shifted to the left or right. The number of rows and columns in the table, as well as the number of rows in each cell, does not change.

In a formatted table, the text in each row of each cell must be separated from the vertical separators by exactly one space on the left and at least one space on the right. All spaces between words are significant. When formatting is allowed only:

to change the number of leading and tailing gaps in the rows of cells;
add and delete characters - in the horizontal separators of the table.
The table does not contain empty columns, i.e. each column has at least one cell with non-empty text.

You need to format the specified table so that its width (the length of the table row) it was minimal.

Source data
The input data contains an edited table. The table consists of no more than 100 rows, and the length of the table row does not exceed 255 characters. Lines do not contain leading and trailing spaces. The file does not contain empty lines. The last row of the table ends with the new line symbol.

Output
You need to output a formatted table to the output file. Output lines must not contain leading and trailing spaces. The output must not contain empty lines. The source data is such that the width of the formatted table does not exceed 255 characters. The last row of the table must end with a newline character.

Example of input data

+-----------+-------+---+                                                 
|Anatoliy       |Ivanov|179|                                                    
+-----------+-------+---+                                            
|Sergey| Petrov|57     |                                                   
+-----------+-------+---+                                                 
|Aleksey| Sidorov-| |                                                           
|       | Vasechkin||                                                         
+-----------+-------+---+

Example of output data

+----------+-----------+-----+                                                         
| Anatoliy | Ivanov    | 179 |                                                    
+----------+-----------+-----+                                                   
| Sergey   | Petrov    | 57  |                                                     
+----------+-----------+-----+                                                    
| Aleksey  | Sidorov-  |     |                                                    
|          | Vasechkin |     |                                                         
+----------+-----------+-----+
     
# Системные требования (версия языка, требования к ресурсам, системные зависимости, нужные расширения)
System requirements:

Windows 7 (x86 and x64) Windows 8 (x86 and x64) Windows Server 2008 R2 (x64) Windows Server 2012 (x64) Supported architectures 32-bit (x86) 64-bit (x64)

Hardware requirements

1.6 GHz processor or higher 1 GB RAM (1.5 GB for a virtual machine) 10 GB (NTFS) of free disk space 5400 rpm hard drive video Adapter compatible with DirectX 9 and supporting a screen resolution of 1024 x 768 pixels or higher
