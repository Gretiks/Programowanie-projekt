   M S B A M L   `   `   `  ����E  AVetManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VetManager.ViewVetManager.View  5   	   "    VetManager.View.AddEditOwner   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:VetManager.View     5   	   $	��250��5   	   $	��400��6   .��5	      �   � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $
��Left=�6    5      �� 5       z� SharedSizeGroup$ 
ButtonSize��6#   .+�5       �� -   5         ��Name$ AnimalListBack��5       $��Wróć��6-   5!      �� 5#   
   $��1��6   $��5��6%    �� Orientation$ 
Horizontal=�69   $��Right=�6R   .+�5$      � $��	10,0,10,0q�6    5%      �� 5&      $ 
ButtonSize��6'   .+�5(      �� -   5        $ AnimalListAdd��5(      $��Dodaj��60   5)      � 5*       5+      �� 5,      $ 
ButtonSize��6'   .+�5.      �� -   5        $ AnimalListDelete��5.      $��Usuń��63   5/      50      �� 52   
   $��2��6   $��0��6!   $��Imie:��61   �� 53   
   -   5        $��tbx_name��53      $��2��6"   $��1��6/   $��2��6?   �� 55   
   $��4��6   $��0��6!   $��	Nazwisko:��61   �� 56   
   -   5        $��tbx_surname��56      $��4��6%   $��1��62   $��2��6B   �� 58   
   $��6��6   $��0��6!   $��2��61   $��Numer telefonu:��6E   �� 59   
   -   5        $��dtp_phonenumber��59      $��6��6)   $��2��66   $��2��6F   5:      5;      