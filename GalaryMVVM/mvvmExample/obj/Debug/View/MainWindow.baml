   M S B A M L   `   `   `  ����F  BmvvmExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:mvvmExamplemvvmExample  5   	   =#clr-namespace:mvvmExample.ViewModelmvvmExample.ViewModel  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   	       mvvmExample.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:mvvmExample     5   	   2vm#clr-namespace:mvvmExample.ViewModel     5   	   binterPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��525��6)    � DataContext 5      /  )mvvmExample.ViewModel.MainWindowViewModel  5   
   -   5        butRemov��5   5   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��161 �6   �� 5      .+�5   
   �� -   5        $��
listOfCars��5      $��5q�6A   ��6$   �� *Cars+��5      �� 5      .R�5      � $	��120��6   $	��100��6'   $��5q�64    5      �� 5      $��4* �6/   �� 5      �� 5      $��0* �6/    � RowDefinitions 5!      �� 5"      $	��23* �6,   �� 5#      $	��54* �6,   �� 5$      $	��23* �6,   .+�5'      �� $��textBlokNameI��6$   $��2��6O   ��69   �� *Name+6f   �� 5(      $��1��6    $��2��6F   ��6-   �� *Image+6\   �� 5)      $��1��6"   ��5*   "   �� ��5+   "   ��  �� ElementName$ butRemov�� �� Path$ RemoveCommand�.��5,   7   X6:   �� 5-      $��2��6"   ��6/   �� *Tag+6M   50      51      53      � 56   
   $��1��6    57      �� 58       5:      �� 5;      $
��110* �6    �� 5<      $	��90* �6    �� 5=      $
��110* �6    .+�5A      9� $��Inform :��6    9� ExpandDirection$
 Down=�6)    9� 
IsExpanded . $��2q�6R   .��5B      �  5C      �� 5D      $	��25* �6(   �� 5E      $	��25* �6(   �� 5F      $	��25* �6(   �� 5G      $	��25* �6(   �� 5H      $	��25* �6(    5J      �� 5K      $��5* �6+   �� 5L      $	��16* �6+   .+�5O      �� Name:6(   �� 5P      $��1��6    Model:65   �� 5Q      $��2��6    Year:64   �� 5R      $��3��6    
Image URL:69   �� 5T      $��1��5V   "   $��0��62   ��5T      �� $ 
listOfCars��$ SelectedItem.Name�5V   A   �� 5W      $��1��6   $��1��6.   ��6;   �� $ 
listOfCars��$ SelectedItem.Model�5X   ]   �� 5Y      $��1��6   $��2��6.   ��6;   �� $ 
listOfCars��$ SelectedItem.Year�5Z   \   �� 5[      $��1��6   $��3��6.   ��6;   �� $ 
listOfCars��$ SelectedItem.Image�.��5\   i   5]      �� 5`      $��4��6A   $��2��5a      $
��50,2q�61   ��5`      �� $ 
AddCommand�.��5a   ?   	Add New6H   5c      5d      9� 5f      $��1��6   $��Sort :��6$   $
 Down=�64    . $��2q�6]   .��5g      �  5h      �� 5i      $	��25* �6(   �� 5j      $	��25* �6(   �� 5k      $	��25* �6(    5o      �� 5p      $
��157* �6+   �� 5q      $
��158* �6+   .+�5t      �� $
��10,5q�5u      ��5t      �� $ sortByNameCommand�.��5u   +   
ByName :65   �� 5v      $��1��6   $
��10,5q�6*   ��5w      �� $ sortByYearCommand�.��6I   
ByYear :5x   #   �� 5y      $��2��6   $
��10,5q�5{      ��5z      �� $ sortByModelCommand�.��5{   +   	ByModel :66   5�      5�      9� 5�      $��1��6   $��	Filters :��6$   $
 Down=�67    . $��	2,134,2,6q�6`   $��2��6s   .��5�      �  5�      �� 5�      $	��84* �6+   �� 5�      $
��281* �6+   .+�5�      �  5�      �� 5�      $	��15* �6,   �� 5�      $	��60* �6,   5�      � 5�       5�      �� 5�      $	��15* �6,   �� 5�      $	��60* �6,   .+�5�      �� $��Tags :��6    $��10, 2q�61   6B   �� 5�      -   5        $��listBoxTags��5�   /   $��1��6"   $��5q�6B   ��5�   "   �� $ 
listOfCars��$ SelectedItem.Tag�5�   S   5�      � 5�      $��1��6    5�      �� 5�      $
��139* �6/   �� 5�      $
��142* �6/    5�      �� 5�      $��5* �6,   �� 5�      $	��19* �6,   .+�5�      �� $��Year with :��6    $��10, 2q�66   6G   �� 5�      -   5        $��
texBoxYear��5�   /   $��1��6"   $��	10,3,3,72q�5�   "   ��5�   "   �� *
YearWiht+ �� UpdateSourceTrigger$ PropertyChanged=�5�   7   �� 5�      $��	ToYears :��6    $��1��64   $��10, 2q�6D   6U   �� 5�      -   5        $��textBoxByYear��5�   "   $��1��5�   "   $��1��6/   $��	3,3,10,72q�5�   "   ��5�   "   �� *YearTo+$ PropertyChanged=�.��5�   5   5�      5�      5�      5�      5�      5�      .  (System.Windows.Interactivity.Interaction	   Triggers	 5�      /  )System.Windows.Interactivity.EventTrigger  5�   
   
   	EventName$
 Closing��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5�      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6(   �� *WindowClosing+5�      5�      