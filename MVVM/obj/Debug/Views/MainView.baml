   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MVVM.Views
MVVM.Views  5   	   1clr-namespace:MVVM.ViewModelsMVVM.ViewModels  5   	       MVVM.Views.MainView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MVVM.Views     5   	   3	viewModelclr-namespace:MVVM.ViewModels     5   	     � Title$  MainView��5	   	   $	��250��6   $	��700��6'    � DataContext 5
      #  MVVM.ViewModels.MainViewModel  5   
    � 	Resources 5         SubmitButtonStyle �� BasedOn �� 
TargetType �� Property �� Value �� Triggers P� Property	 P� Value��%�  &	        7���� 5   
   8   " ��5      .�5      ��  � ��$ 25��6'   �� 5       � ��$	 150��6&   �� 5       � ��$ 2q�60   �� 5       � ��$ 2q�60   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ Trigger Not Applied��6(   �� 5       � ��
 �   �6,   �� 5       � ��
 �����6+   �� 5       � ��
 �����6+    5      P� 5       �@J�IsMouseOver	 . . �5      ��  � ��$ Trigger Applied��60   �� 5       � ��
 �����64   �� 5        � ��
 ��  �63   �� 5!       � ��
 �   �63   5"      5$      5%      .��5&      � 
 � RowDefinitions
 5'   
   �� 5(      $��10 �6   �� 5)      $��40 �6   �� 5*      $��40 �6   �� 5+      $��40 �6   �� 5,      $��* �6    � ColumnDefinitions 5.   
   �� 5/      $��50 �6   �� 50      $	��100 �6   �� 51      $	��500 �6   �� 52      $��50 �6   .+�55   
   �� $��1��6   $��1��6   $
��Name��6-   �� 56   
   $��2��6   $��1��6   $
��Rate��6-   �� 57   
   $��3��6   $��1��6   $��Amount��6-   �� 59   
   -   5        $��NameText��59   /   $��1��6   $��2��6   $��10q�6?   ��6L   ��  �� Path$
 Name� �� UpdateSourceTrigger$ PropertyChanged=��� 5:   
   -   5        $
��Rate��5:   /   $��2��6   $��2��6   $��10q�6;   ��6H   �� $
 Rate�$ PropertyChanged=��� 5;   
   -   5        $��Amount��5;   /   $��3��6   $��2��6   $��10q�6=   ��6J   �� $ Amount�$ PropertyChanged=��� 5<   
   -   5        $��Title��5<   -   $��4��6   $��2��6   ��6:   �� *Title+ �� Mode$ TwoWay=�5=      5>      