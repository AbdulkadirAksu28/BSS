   M S B A M L   `   `   `  ���� ?  ;BSS3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BSS3BSS3      BSS3.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $localclr-namespace:BSS3       � Title$  Blad Steen Schaar��$	��600��$
��1100��.��(� .��� 
�������$	��600�� � ColumnDefinitions �� $	��200 ��� $	��300 ��� $	��300 ��� $	��300 � � RowDefinitions �� $	��100 ��� $	��350 �.+��� -    ��Name$ btnPaper��$��10q�$��0��$��1��$
��Left=�$	��Top=�$��0,0,0,0q�$	��110��$	��200������  �� ImageSource$ /images/paper-tint.png�� j� Stretch$
 fill=��� -   $ btnSteen��$��10q�$��0��$��1��$
��Left=�$	��Top=�$��	0,110,0,0q�$	��110��$	��200������ $ /images/rock-tint.png��$
 fill=��� -   $ 	btnSchaar��$��10q�$��0��$��1��$
��Left=�$	��Top=�$��	0,220,0,0q�$	��100��$	��200������ $ /images/scissorstint.png��$
 fill=��� -    ��Name$ 
textPlayer��$��1��$��1��$
��Left=�$	��320��$��0,0,0,0q� K� ZIndex$ 1�� �� TextWrapping$
 Wrap=�$	��Top=�$	��300��
����ح�$��1(�$��Center=�$��Center=��� -   $ textPC��$��2��$��1��$
��Left=�$	��320��$��0,0,0,0q�$ 1��$
 Wrap=�$	��Top=�$	��300��
����·�$��1(�$��Center=�$��Center=��� -   $ textHistory��$��1��$��3��$
��Left=�$	��320��$��0,0,0,0q�$ 1��$
 Wrap=�$	��Top=�$	��300��
����ح�$��1(�$��Center=�$��Center=��� $��ABDULKADIR'S GAME��$��Comic Sans MS)�$��17(�$��Italic$�$
��Bold"�$
��Left=�$��0,40,0,0q�$	��Top=�$��45��$	��200���� -   	 ��Name$	 
playerName��$�� ��$��1��$��0��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$
��Left=�$��1,18,0,0q�$	��Top=�$	��257��$��Center=��� $��Speler:��$��1��$��0��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$
��Left=�$��	70,40,0,0q�$	��Top=�$��90��$��Right=��� -   $	 lblPuntSpeler��$�� ��$��1��$��0��$
��Left=�$��
160,40,0,0q�$	��Top=�$��40��$
��Bold"�$��15(��� -	   $	 naamPc��$��	Computer:��$��2��$��0��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$
��Left=�$��	70,40,0,0q�$	��Top=�$��90��$��Right=��� -
   $	 	lblPuntPC��$�� ��$��2��$��0��$
��Left=�$��
160,40,0,0q�$	��Top=�$��40��$
��Bold"�$��15(��� -   $	 algemeenPuntSpeler��$ 2��$�� ��$��1��$��1��$
��Left=�$��100,280,0,0q�$	��Top=�$��Center=�$	��100��$
��Bold"�$��15(����� 
 �� Color$
 Transparent���� -   $	 algemeenPuntPC��$�� ��$ 2��$��2��$��1��$
��Left=�$��100,280,0,0q�$	��Top=�$	��100��$
��Bold"�$��15(�$��Center=����� $
 Transparent���� -   $ 	imgPlayer��
������ $��1��$
��Left=�$	��250��$��	10,15,0,0q�$ 0��$��1��$	��Top=�$	��280���� -   $ imgPc��
������ $��2��$
��Left=�$	��250��$��	10,15,0,0q�$ 0��$��1��$	��Top=�$	��280���� -   $	 lblTijd��$��3��$
��Left=�$	��Top=�$��2��$��1��$��	220,0,0,0q�$	��100��$	��160��$��Center=�$��Center=�$��70(��� $��History��$��3��$��0��$��Comic Sans MS)�$��20(�$��Italic$�$
��Bold"�$
��Left=�$��	96,19,0,0q�$	��Top=�$��90��$��Right=��� $��Speler��$��Comic Sans MS)�$��17(�$��Italic$�$
��Bold"�$��Center=�$��Center=�$ 1��$��3��$
��Left=�$��36��$��4,65,0,0q�$	��Top=�$	��100���� $��Computer��$��Comic Sans MS)�$��17(�$��Italic$�$
��Bold"�$��Center=�$��Center=�$ 1��$��3��$
��Left=�$��36��$��
180,65,0,0q�$	��Top=�$	��100��$��2���� $��Blad:��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$��3��$ 1��$
��Left=�$��	20,40,0,0q�$��1��$	��Top=�$��30��$��70���� $��Steen:��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$��3��$ 1��$
��Left=�$��
20,100,0,0q�$��1��$	��Top=�$��30��$��70���� $��Schaar:��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$��3��$ 1��$
��Left=�$��
20,160,0,0q�$��1��$	��Top=�$��30��$��70���� $��Blad:��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$��3��$ 1��$
��Left=�$��
190,40,0,0q�$��1��$	��Top=�$��30��$��70���� $��Steen:��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$��3��$ 1��$
��Left=�$��190,100,0,0q�$��1��$	��Top=�$��30��$��70���� $��Schaar:��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$��3��$ 1��$
��Left=�$��190,160,0,0q�$��1��$	��Top=�$��30��$��70���� -   $	 lblAantalSpelerBlad��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$��3��$
��Left=�$��	60,40,0,0q�$��1��$	��Top=�$ 1��$��30��$��30���� -   $	 lblAantalPcBlad��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$��3��$
��Left=�$��
230,40,0,0q�$��1��$	��Top=�$ 1��$��30��$��30���� -   $	 lblAantalSpelerSteen��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$��3��$
��Left=�$��
70,100,0,0q�$��1��$	��Top=�$ 1��$��30��$��40���� -   $	 lblAantalPcSteen��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$��3��$
��Left=�$��240,100,0,0q�$��1��$	��Top=�$ 1��$��30��$��40���� -   $	 lblAantalSpelerSchaar��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$��3��$
��Left=�$��
80,160,0,0q�$��1��$	��Top=�$ 1��$��30��$��40���� -   $	 lblAantalPcSchaar��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$��3��$
��Left=�$��250,160,0,0q�$��1��$	��Top=�$ 1��$��30��$��40��$�� ���� -    ��Name$ historiekText��
�������$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$��Right=�$	��167��$��0,322,1,-138q�$��1��$
��Wrap=�$	��Top=�$	��900��$��4���� -   $ startBtn��$��
Start game��$y�Visible=�
����ح�{�. $��17(�$��Italic$�$
��Left=�$��20,8,0,0q�$	��Top=�$	��165��$��40�� � 	Resources  �� 
TargetType �� Property �� Value��%�   '��       �� " ��.���  � ��
 ���_���  � ��$	 100����  � ��$ 75����  � ��$ Comic Sans MS)���  � ��$
 Bold"���  � ��$ 15(���  � ��
 �������  � y�$ Hidden=�