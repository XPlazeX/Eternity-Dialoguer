   M S B A M L   `   `   `  ����L  HEternity Dialoger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Eternity_DialogerEternity_Dialoger  5   	   "    Eternity_Dialoger.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Eternity_Dialoger     5   	   -   5          � Title$  Eternity Dialoguer��5   	    � Icon$* $/resources/EternityDialoguerIcon.png��5	   	      commonBG#���   5
   	    � WindowStartupLocation$ CenterScreen=�5   	   $	��496��5   	   $
��1348��6   $
��1348��6:   $	��250��6J   $
��1470��6Z    � 	Resources 5       �� Color  	lightenBG  headerBG  	lineColor  headerTextColor=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value �� 
TargetType	 �� Triggers
 P� Property P� Value)  #System.Windows.Controls.DataGridRow $  Body_Content_Data_Grid_Centering*  $System.Windows.Controls.DataGridCell��%�  &	        &	 (     &	 P     &	 x     &	 �     '  �     7  7  '�� L    '  �    7  &	 �    �� 5   
   $ 	#FF242429��6   6,   �� 5   
   $ 	#FF32323C��6   6,   �� 5   
   $ 	#FFF3FF00��6   6,   �� 5   
   $ 	#FF2B5155��6   6,   �� 5   
   $ Black��6   6(   �� 5   
   "  6   .�5      ��  � ��$ 35��6'   �� 5       � ��8   6+   �� 5       � ��8  6+   5      �� 5   
   " ��6   .�5      ��  � �� �	#FFF3FF006+   �� 5       � ��# �  6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   
���   �$��1q�6_   ._�5      �� $��Center=�6/   $��Center=�6L   5       5!      5#      	 5$      P� 5%      
 �@J�IsMouseOver . . �5&      ��  � ��
 ��� �63   5'      5)      �� 5*   
   "  6   .�5+      ��  � ��$ 25��6'   �� 5,       � ��$ Center=�69   �� 5-       � ��8   6+   �� 5.       � ��
 �����6+   5/      �� 50   
   "  69   .�51      ��  � ��$ 25��6'   �� 52       � �� 53      �� 54      "  6&   .R�55      � #��z��6   .+�56      �� $��Center=�6/   57      58      5:      5;      5=      .��5>      � .+�5?   
   &   System.Windows.Controls.DataGrid  -   5          Name$ constructGrid��5?      $��./resources/#galvanic)�5@      $��0,0,0,45q�66      AutoGenerateColumns .  $��2q�6d   #��[ 5A      #��[  6;      HeadersVisibility$ Column=�5B         CanUserAddRows .     CanUserDeleteRows .     	CellStyle# [ 5D      ��5?   *   �� *DialogueObjects+   Columns 5E      4  .System.Windows.Controls.DataGridTemplateColumn  5F      ,  &System.Windows.Controls.DataGridColumn   Header$ Наша речь?��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6=      CellTemplate 5G      �� 5H      .R�5I      �� $��Center=�6n    d� 	IsChecked 6'   ��  �� Path$ IsHero� �� UpdateSourceTrigger$ PropertyChanged=�6n   5J      5L      4  .System.Windows.Controls.DataGridComboBoxColumn  5M         DisplayMemberPath$
 Name��5O         SelectedValuePath$ ID��5P      $ Персонаж��5Q      $	 170 6'      SelectedValueBinding 5N      �� *CharacterID+   ElementStyle 5R      �� 5S      " ��6    .�5T      ��  � �� 6<   �� $  DataContext.CharacterTypes� �� RelativeSource ��  �� AncestorType" �5U         EditingElementStyle 5W      �� 5X      " ��6    .�5Y      ��  � �� 6<   �� $  DataContext.CharacterTypes� �� " ��� 5Z       �@��IsDropDownOpen . 6?   5[      5]        5^      $
 Name��5`      $ ID��5a      $ 
Голос��5b      $	 150 6$    5_      �� *	VoiceID+ 5c      �� 5d      " ��6    .�5e      ��  � �� 6<   �� $ DataContext.VoiceTypes� �� " �5f       5h      �� 5i      " ��6    .�5j      ��  � �� 6<   �� $ DataContext.VoiceTypes� �� " ��� 5k       �@��IsDropDownOpen . 6?   5l      5n        5o      $
 Time��5q      $ ID��5r      $ Время речи��5s      $	 100 6)    5p      �� *
DurationID+ 5t      �� 5u      " ��6    .�5v      ��  � �� 6<   �� $ DataContext.DurationTypes� �� " �5w       5y      �� 5z      " ��6    .�5{      ��  � �� 6<   �� $ DataContext.DurationTypes� �� " ��� 5|       �@��IsDropDownOpen . 6?   5}      5      0	  *System.Windows.Controls.DataGridTextColumn	  5�      $q kТекст (Окно открыто с учётом максимальной длины сообщения)��6C   $ * 6�   1
  +System.Windows.Controls.DataGridBoundColumn  
  Binding  6%   �� $
 Text�6�   5�      �� 5�   
   -   5        ! ��Name$! button��5�      $#��+ Добавить фразу��6!   $��./resources/#galvanic)�6<   $��0,0,0,0q�6_   $��Right=�6p   $	��150��6�   $��40��6�   $��Bottom=�6�   ���	#FFF3FF006�   �� 5�   
   -   5        $! 	delButton��5�      $!��- Удалить фразу��6$   $��./resources/#galvanic)�6>   $��	0,0,155,0q�6a   $��Right=�6t   $	��150��6�   $��40��6�   $��Bottom=�6�   ���	#FFFF80006�   �� 5�   
   -   5        $! 
openButton��5�      $��Открыть CSV��6%   $��./resources/#galvanic)�6;   $��	0,0,310,0q�6^   $��Right=�6q   $	��150��6�   $��40��6�   $��Bottom=�6�   ���	#FFF3FF006�   �� 5�   
   -   5        $! 
saveButton��5�      $��Сохранить CSV��6%   $��./resources/#galvanic)�6=   $��	0,0,465,0q�6`   $��Right=�6s   $	��150��6�   $��40��6�   $��Bottom=�6�   ���	#FFF3FF006�   �� 5�   
   -   5        $! clButton��5�      $#��Снять выделение��6#   $��./resources/#galvanic)�6=   $��	0,0,620,0q�6`   $��Right=�6s   $	��150��6�   $��40��6�   $��Bottom=�6�   ���	#FFF3FF006�   �� 5�   
   -   5        $! 
autoButton��5�      $��Автополя��6%   $��./resources/#galvanic)�68   $��	0,0,775,0q�6[   $��Right=�6n   $	��150��6�   $��40��6�   $��Bottom=�6�   ���	#FFF3FF006�   �� 5�   
   -	   5        $! configButton��5�      $��Настройки��6'   $��./resources/#galvanic)�6;   $��	0,0,930,0q�6^   $��Right=�6q   $	��150��6�   $��40��6�   $��Bottom=�6�   ���	#FFF3FF006�   �� 5�   
   -
   5        " ��Name$" counterLabel��5�      $��Label��6&   $��./resources/#galvanic)�66   $
��Left=�6Y   $��	10,0,0,10q�6t   $	��220��6�   ���	#FFF3FF00$��24��6�   $��Bottom=�6�   5�      5�      