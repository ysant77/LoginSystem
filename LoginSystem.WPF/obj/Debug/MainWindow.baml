   M S B A M L   `   `   `  ����J  FLoginSystem.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:LoginSystem.WPFLoginSystem.WPF  5   	        LoginSystem.WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:LoginSystem.WPF     5   	     � Title$  Login System��5   	   $	��450��6   $	��800��6+   $	��600��5	   	   $	��400��6   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   ��5      �� 5       �� 
TargetType" �6    �� Triggers 5      �� 5       �� Binding 6&   �� *
IsLoggedIn+ �� Value	 False6E   .a�5      ��  �� Property � y� �� Value$ 	Collapsed=�6;   5      5      5      �� 5   
   $��1��6   $
��Auto=�6$   $��Disabled=�6G   .��5      �� ��6   �� *CurrentViewModel+5      5      5       