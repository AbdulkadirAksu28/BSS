   M S B A M L   `   `   `  ���� ?  ;BSS2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BSS2BSS2      BSS2.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $localclr-namespace:BSS2       � Title$  Blad Steen Schaar��$	��450��$	��800��.��(� .��� 
������� � ColumnDefinitions �� $	��200 ��� $	��300 ��� $	��300 � � RowDefinitions �� $	��100 ��� $	��350 �.+��� -    ��Name$ btnPaper��$��10q�$��0��$��1��$
��Left=�$	��Top=�$��0,0,0,0q�$	��110��$	��200������  �� ImageSource$ /images/papers.jpg�� j� Stretch$ UniformToFill=��� -   $ btnSteen��$��10q�$��0��$��1��$
��Left=�$	��Top=�$��	0,110,0,0q�$	��110��$	��200������ $ /images/rock-tint.jpg��$ UniformToFill=��� -   $ 	btnSchaar��$��10q�$��0��$��1��$
��Left=�$	��Top=�$��	0,220,0,0q�$	��100��$	��200������ $ /images/scissorstint.jpg��$ UniformToFill=��� -    ��Name$ 
TextPlayer��$��1��$��1��$
��Left=�$	��320��$��0,0,0,0q� K� ZIndex$ 1�� �� TextWrapping$
 Wrap=�$	��Top=�$	��300��
����ح�$��60(�$��Center=�$��Center=��� -   $ TextPC��$��2��$��1��$
��Left=�$	��320��$��0,0,0,0q�$ 1��$
 Wrap=�$	��Top=�$	��300��
����·�$��60(�$��Center=�$��Center=��� $��ABDULKADIR'S GAME��$��Comic Sans MS)�$��17(�$��Italic$�$
��Bold"�$
��Left=�$��0,40,0,0q�$	��Top=�$��45��$	��200���� $��Speler:��$��1��$��0��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$
��Left=�$��	70,40,0,0q�$	��Top=�$��90��$��Right=��� -   	 ��Name$	 lblPuntSpeler��$�� ��$��1��$��0��$
��Left=�$��
160,40,0,0q�$	��Top=�$��40��$
��Bold"�$��15(��� $��	Computer:��$��2��$��0��$��Comic Sans MS)�$��15(�$��Italic$�$
��Bold"�$
��Left=�$��	70,40,0,0q�$	��Top=�$��90��$��Right=��� -   $	 	lblPuntPC��$�� ��$��2��$��0��$
��Left=�$��
160,40,0,0q�$	��Top=�$��40��$
��Bold"�$��15(��� -   $	 AlgemeenPuntSpeler��$ 2��$�� ��$��1��$��1��$
��Left=�$��100,280,0,0q�$	��Top=�$��Center=�$	��100��$
��Bold"�$��15(����� 
 �� Color$
 Transparent���� -	   $	 AlgemeenPuntPC��$�� ��$ 2��$��2��$��1��$
��Left=�$��100,280,0,0q�$	��Top=�$	��100��$
��Bold"�$��15(�$��Center=����� $
 Transparent���� -
   $ 	imgPlayer��$��1��$
��Left=�$	��200��$��	50,75,0,0q�$ 0��$��1��$	��Top=�$	��200���� -   $ imgPc��$��2��$
��Left=�$	��200��$��	50,75,0,0q�$ 0��$��1��$	��Top=�$	��200���� -   $	 lblTijd��$��3��$
��Left=�$	��Top=�$��2��$��1��$��	220,0,0,0q�$	��100��$	��160��$��Center=�$��Center=�$��70(� � 	Resources  �� 
TargetType �� Property �� Value��%�   '��       �� " ��.���  � ��
 ���_���  � ��$	 100����  � ��$ 75����  � ��$ Comic Sans MS)���  � ��$
 Bold"���  � ��$ 15(���  � ��
 �����