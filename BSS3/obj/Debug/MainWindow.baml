   M S B A M L   `   `   `  ����?  ;BSS3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BSS3BSS3  5   	       BSS3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:BSS3     5   	     � Title$  Blad Steen Schaar��5   	   $	��600��6#   $
��1100��60   .��5	      (� .��5
   
   � 
�������$	��600��6&    � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $	��300 �6#   �� 5      $	��300 �6#   �� 5      $	��300 �6#    � RowDefinitions 5      �� 5      $	��100 �6    �� 5      $	��350 �6    .+�5      �� -   5         ��Name$ btnPaper��5      $��10q�6)   $��0��6?   $��1��6O   $
��Left=�6\   $	��Top=�6w   $��0,0,0,0q�6�   $	��110��6�   $	��200��6�   ��5      �� 5       �� ImageSource$ /images/paper-tint.png��6!    j� Stretch$
 fill=�6F   5      �� 5      -   5        $ btnSteen��5      $��10q�6'   $��0��6=   $��1��6M   $
��Left=�6Z   $	��Top=�6u   $��	0,110,0,0q�6�   $	��110��6�   $	��200��6�   ��5      �� 5      $ /images/rock-tint.png��6!   $
 fill=�6E   5       �� 5"      -   5        $ 	btnSchaar��5"      $��10q�6*   $��0��6@   $��1��6P   $
��Left=�6]   $	��Top=�6x   $��	0,220,0,0q�6�   $	��100��6�   $	��200��6�   ��5#      �� 5$      $ /images/scissorstint.png��6!   $
 fill=�6H   5&      �� 5(      -   5         ��Name$ 
textPlayer��5(      $��1��6*   $��1��6:   $
��Left=�6G   $	��320��6c   $��0,0,0,0q�6p    K� ZIndex$ 1��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��300��6�   
����ح�$��1(�6�   $��Center=�6�   $��Center=�6  �� 5)      -   5        $ textPC��5)      $��2��6&   $��1��66   $
��Left=�6C   $	��320��6^   $��0,0,0,0q�6k   $ 1��6|   $
 Wrap=�6�   $	��Top=�6�   $	��300��6�   
����·�$��1(�6�   $��Center=�6�   $��Center=�6  �� 5*      -   5        $ textHistory��5*      $��1��6+   $��3��68   $
��Left=�6H   $	��320��6d   $��0,0,0,0q�6q   $ 1��6�   $
 Wrap=�6�   $	��Top=�6�   $	��300��6�   
����ح�$��1(�6�   $��Center=�6�   $��Center=�6  �� 5+      $��ABDULKADIR'S GAME��6   $��Comic Sans MS)�60   $��17(�6K   $��Italic$�6Y   $
��Bold"�6l   $
��Left=�6~   $��0,40,0,0q�6�   $	��Top=�6�   $��45��6�   $	��200��6�   �� 5,      -   5        	 ��Name$	 
playerName��5,      $�� ��6(   $��1��63   $��0��6C   $��Comic Sans MS)�6P   $��15(�6k   $��Italic$�6y   $
��Bold"�6�   $
��Left=�6�   $��1,18,0,0q�6�   $	��Top=�6�   $	��257��6�   $��Center=�6�   �� 5-      $��Speler:��6   $��1��6&   $��0��66   $��Comic Sans MS)�6C   $��15(�6^   $��Italic$�6l   $
��Bold"�6   $
��Left=�6�   $��	70,40,0,0q�6�   $	��Top=�6�   $��90��6�   $��Right=�6�   �� 5.      -   5        $	 lblPuntSpeler��5.      $�� ��6+   $��1��66   $��0��6F   $
��Left=�6S   $��
160,40,0,0q�6n   $	��Top=�6�   $��40��6�   $
��Bold"�6�   $��15(�6�   �� 5/      -	   5        $	 naamPc��5/      $��	Computer:��6$   $��2��68   $��0��6H   $��Comic Sans MS)�6U   $��15(�6p   $��Italic$�6~   $
��Bold"�6�   $
��Left=�6�   $��	70,40,0,0q�6�   $	��Top=�6�   $��90��6�   $��Right=�6�   �� 50      -
   5        $	 	lblPuntPC��50      $�� ��6'   $��2��62   $��0��6B   $
��Left=�6O   $��
160,40,0,0q�6j   $	��Top=�6~   $��40��6�   $
��Bold"�6�   $��15(�6�   �� 51      -   5        $	 algemeenPuntSpeler��51      $ 2��60   $�� ��6A   $��1��6L   $��1��6\   $
��Left=�6i   $��100,280,0,0q�6�   $	��Top=�6�   $��Center=�6�   $	��100��6�   $
��Bold"�6�   $��15(�6�   ��52      �� 53      
 �� Color$
 Transparent��6&   55      �� 56      -   5        $	 algemeenPuntPC��56      $�� ��6,   $ 2��67   $��2��6H   $��1��6X   $
��Left=�6e   $��100,280,0,0q�6�   $	��Top=�6�   $	��100��6�   $
��Bold"�6�   $��15(�6�   $��Center=�6�   ��57      �� 58      $
 Transparent��6&   5:      �� 5;      -   5        $ 	imgPlayer��5;      
������ $��1��6A   $
��Left=�6Q   $	��250��6l   $��	10,15,0,0q�6y   $ 0��6�   $��1��6�   $	��Top=�6�   $	��280��6�   �� 5<      -   5        $ imgPc��5<      
������ $��2��6=   $
��Left=�6M   $	��250��6h   $��	10,15,0,0q�6u   $ 0��6�   $��1��6�   $	��Top=�6�   $	��280��6�   �� 5=      -   5        $	 lblTijd��5=      $��3��6%   $
��Left=�61   $	��Top=�6L   $��2��6d   $��1��6x   $��	220,0,0,0q�6�   $	��100��6�   $	��160��6�   $��Center=�6�   $��Center=�6�   $��70(�6�   �� 5>      $��History��6   $��3��6&   $��0��66   $��Comic Sans MS)�6C   $��20(�6^   $��Italic$�6l   $
��Bold"�6   $
��Left=�6�   $��	96,19,0,0q�6�   $	��Top=�6�   $��90��6�   $��Right=�6�   �� 5?      $��Speler��6   $��Comic Sans MS)�6%   $��17(�6@   $��Italic$�6N   $
��Bold"�6a   $��Center=�6s   $��Center=�6�   $ 1��6�   $��3��6�   $
��Left=�6�   $��36��6�   $��4,65,0,0q�6  $	��Top=�6  $	��100��6+  �� 5@      $��Computer��6   $��Comic Sans MS)�6'   $��17(�6B   $��Italic$�6P   $
��Bold"�6c   $��Center=�6u   $��Center=�6�   $ 1��6�   $��3��6�   $
��Left=�6�   $��36��6�   $��
180,65,0,0q�6  $	��Top=�6  $	��100��6/  $��2��6;  �� 5A      $��Blad:��6   $��Comic Sans MS)�6$   $��15(�6?   $��Italic$�6M   $
��Bold"�6`   $��3��6r   $ 1��6�   $
��Left=�6�   $��	20,40,0,0q�6�   $��1��6�   $	��Top=�6�   $��30��6�   $��70��6�   �� 5B      $��Steen:��6   $��Comic Sans MS)�6%   $��15(�6@   $��Italic$�6N   $
��Bold"�6a   $��3��6s   $ 1��6�   $
��Left=�6�   $��
20,100,0,0q�6�   $��1��6�   $	��Top=�6�   $��30��6�   $��70��6�   �� 5C      $��Schaar:��6   $��Comic Sans MS)�6&   $��15(�6A   $��Italic$�6O   $
��Bold"�6b   $��3��6t   $ 1��6�   $
��Left=�6�   $��
20,160,0,0q�6�   $��1��6�   $	��Top=�6�   $��30��6�   $��70��6�   �� 5D      $��Blad:��6   $��Comic Sans MS)�6$   $��15(�6?   $��Italic$�6M   $
��Bold"�6`   $��3��6r   $ 1��6�   $
��Left=�6�   $��
190,40,0,0q�6�   $��1��6�   $	��Top=�6�   $��30��6�   $��70��6�   �� 5E      $��Steen:��6   $��Comic Sans MS)�6%   $��15(�6@   $��Italic$�6N   $
��Bold"�6a   $��3��6s   $ 1��6�   $
��Left=�6�   $��190,100,0,0q�6�   $��1��6�   $	��Top=�6�   $��30��6�   $��70��6�   �� 5F      $��Schaar:��6   $��Comic Sans MS)�6&   $��15(�6A   $��Italic$�6O   $
��Bold"�6b   $��3��6t   $ 1��6�   $
��Left=�6�   $��190,160,0,0q�6�   $��1��6�   $	��Top=�6�   $��30��6�   $��70��6�   �� 5G      -   5        $	 lblAantalSpelerBlad��5G      $��Comic Sans MS)�61   $��15(�6L   $��Italic$�6Z   $
��Bold"�6m   $��3��6�   $
��Left=�6�   $��	60,40,0,0q�6�   $��1��6�   $	��Top=�6�   $ 1��6�   $��30��6�   $��30��6   �� 5H      -   5        $	 lblAantalPcBlad��5H      $��Comic Sans MS)�6-   $��15(�6H   $��Italic$�6V   $
��Bold"�6i   $��3��6{   $
��Left=�6�   $��
230,40,0,0q�6�   $��1��6�   $	��Top=�6�   $ 1��6�   $��30��6�   $��30��6�   �� 5I      -   5        $	 lblAantalSpelerSteen��5I      $��Comic Sans MS)�62   $��15(�6M   $��Italic$�6[   $
��Bold"�6n   $��3��6�   $
��Left=�6�   $��
70,100,0,0q�6�   $��1��6�   $	��Top=�6�   $ 1��6�   $��30��6�   $��40��6  �� 5J      -   5        $	 lblAantalPcSteen��5J      $��Comic Sans MS)�6.   $��15(�6I   $��Italic$�6W   $
��Bold"�6j   $��3��6}   $
��Left=�6�   $��240,100,0,0q�6�   $��1��6�   $	��Top=�6�   $ 1��6�   $��30��6�   $��40��6�   �� 5K      -   5        $	 lblAantalSpelerSchaar��5K      $��Comic Sans MS)�63   $��15(�6N   $��Italic$�6\   $
��Bold"�6o   $��3��6�   $
��Left=�6�   $��
80,160,0,0q�6�   $��1��6�   $	��Top=�6�   $ 1��6�   $��30��6�   $��40��6  �� 5L      -   5        $	 lblAantalPcSchaar��5L      $��Comic Sans MS)�6/   $��15(�6J   $��Italic$�6X   $
��Bold"�6k   $��3��6~   $
��Left=�6�   $��250,160,0,0q�6�   $��1��6�   $	��Top=�6�   $ 1��6�   $��30��6�   $��40��6   $�� ��6  �� 5M      -   5         ��Name$ historiekText��5M      
�������$��Comic Sans MS)�6B   $��15(�6]   $��Italic$�6k   $
��Bold"�6~   $��Right=�6�   $	��167��6�   $��0,322,1,-138q�6�   $��1��6�   $
��Wrap=�6�   $	��Top=�6�   $	��900��6	  $��4��6  �� 5N      -   5        $ startBtn��5N      $��
Start game��6'   $y�Visible=�6<   
����ح�{�. $��17(�6y   $��Italic$�6�   $
��Left=�6�   $��20,8,0,0q�6�   $	��Top=�6�   $	��165��6�   $��40��6�   6�   5O      5P       � 	Resources 5Q       �� 
TargetType �� Property �� Value��%�  '��       �� 5R   
   " ��6   .�5S      ��  � ��
 ���_�6?   �� 5T       � ��$	 100��6&   64   �� 5U       � ��$ 75��6'   64   �� 5V       � ��$ Comic Sans MS)�6+   6C   �� 5W       � ��$
 Bold"�6+   6:   �� 5X       � ��$ 15(�6)   66   �� 5Y       � ��
 �����6;   �� 5Z       � y�$ Hidden=�6+   6<   5[      5\      5]      