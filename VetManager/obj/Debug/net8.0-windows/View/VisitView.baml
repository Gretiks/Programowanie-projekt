   M S B A M L   `   `   `  ����E  AVetManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VetManager.ViewVetManager.View  5   	       VetManager.View.VisitView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:VetManager.View     5   	   $	��450��5   	   $	��800��6   .��5	      �   � RowDefinitions  5
   
   �� 5      $��1* �6   �� 5      $	��15* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   +�5   
   � 5      $��2��6    � IsSharedSizeScope$
 True��6'   $��	10,0,10,0q�6E    5      �� 5      �� 5      .+�5      � $
��Left=�6    5      �� 5       z� SharedSizeGroup$ 
ButtonSize��6+   .+�5      �� -   5         ��Name$ 
AnimalBack��5      $��Wróć��61   5      �� 5       $��1��6    �� Orientation$ 
Horizontal=�6-   $��Right=�6F   .+�5!      � $��	10,0,10,0q�6    5"      �� 5#      $ 
ButtonSize��6/   .+�5%      �� -   5        $ 
AnimalSave��5%   !   $��Zapisz��65   5&      � 5'       5(      �� 5)      $ 
ButtonSize��6/   .+�5+      �� -   5        $ AnimalClear��5+   !   $��	Wyczyść��66   5,      5-      5.      �� 50      $��1��6   .+�51      �� $��Data:��6   �� 52      -   5         ��Name$ tbx_date��52      �� 53      $��Godzina rozpoczęcia:��6   �� 54      -   5        $ tbx_starthour��54      �� 55      $��Godzina zakończenia:��6   �� 56      -   5        $ tbx_endhour��56      �� 57      $��Zwierze:��6   �� 58      -   5        $ 
tbx_animal��58      �� 59      $��Właściciel:��6   �� 5:      -   5        $ 	tbx_owner��5:      �� 5;      $��Typ wizyty:��6   �� 5<      -	   5        $ tbx_type��5<      5=      �� 5?      $��1��6   $��1��6)   .+�5@      �� $��Opis wizyty:��6   �� 5A      -
   5        $��tbx_description��5A      $��60��61   $	��250��6=   $
��Left=�6I   5B      5D      5E      