   M S B A M L   `   `   `  ����_  [prog2500_assignment1_matheusoliveira, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:prog2500_assignment1_matheusoliveira$prog2500_assignment1_matheusoliveira  5   	   5    /prog2500_assignment1_matheusoliveira.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:prog2500_assignment1_matheusoliveira     5   	     � Title$  Media Tagger��5   	   $	��450��6   $	��600��6+    � 	Resources 5	       �� 
TargetType �� Property �� Value��%w   '��       �� 5
   
   " ��6   .�5      ��  � ��$ 0q�60   �� 5       � ��
 �����6+   5      5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Open��5      6Y     5   
   -   5        $ MediaCommands.Play��5      6S     5   
   -   5        $ MediaCommands.Pause��5      6U     5   
   -   5        $ MediaCommands.Stop��5      6S   .��5      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m�  m� Command$ ApplicationCommands.Open��6   $��Open MP3��6>   m� 5      -   5         m�Name$ menuEdit��5      $��Tag Current MP3��6-   ${�False��6\   �� 5      m� 5      -   5        $
��Exit��5      6)   5      m� 5      $��Media��6   .@�5      m� -   5        $ 
headerPlay��5      $
��Play��6/   $ MediaCommands.Play��6=   m� 5      -   5        $ headerPause��5      $��Pause��60   $ MediaCommands.Pause��6?   m� 5       -	   5        $ 
headerStop��5       $
��Stop��6/   $ MediaCommands.Stop��6=   5!      5"      �� 5#   
   $
��Left=�6   $��60��6+   
�������$��Stretch=�6M   $
��Auto��6i   .+�5$      �� -
   5        	 ��Name$	 openFile��5$      $��2,2,2,0q�68   .��5%      �� $��Images/open_file.png��6   $
��Fill=�66   5&      r� 5'      -   5        
 r�Name$
 mediaPlayer��5'       r� UnloadedBehavior$ Manual=�60    r� LoadedBehavior$ Manual=�6J   6d   �� 5(      -   5         ��Name$ fileNameBox��5(      $y�	Collapsed=�6+   6D   �� 5)      6   �� 5*      -   5        $	 
btnPlaying��5*      $��2,2,2,0q�6F   ${�False��6W   .��5+      �� $��Images/musicnote.png��6   5,      �� 5-      6   �� 5.      -   5        $	 btnEdit��5.      $��2,2,2,0q�6@   ${�False��6Q   .��5/      �� $��Images/edit.png��6   50      �� 51      6   52      �� 53   
   $��Bottom=�6    �� Orientation$ 
Horizontal=�6-   $��40��6F   
�������.+�54      ��  � LayoutTransform 55      �� 56       �� Angle$ 90Q�6&   58      �� 59      $��MediaCommands.Play��6   .��5:      �� $��Images/media-play.png��6   5;      �� 5<       5=      �� 5>      $ 90Q�6&   5@      �� 5A      $��MediaCommands.Pause��6   .��5B      �� $��Images/pause-icon.png��6   5C      �� 5D       5E      �� 5F      $ 90Q�6&   5H      �� 5I      $��MediaCommands.Stop��6   .��5J      �� $��Images/stop-icon.png��6   5K      �� 5L       5M      �� 5N      $ 90Q�6&   5P      5Q      � 5R   
   -   5         �Name$ screen��5R      .+�5S      �� ��5T      �� 5U       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5V      �  � Color$ Black��6'    � Offset$ 0.988Q�65   � 5W      $ 	#FF6776F5��6'   $ 0.626Q�69   5X      5Z      <   6prog2500_assignment1_matheusoliveira.NowPlayingControl  5[      -   5          Name$ 
nowPlaying��5[   &   $y�Hidden=�6:   ;   5prog2500_assignment1_matheusoliveira.TagEditorControl  5\      -   5          Name$ tagEditorControl��5\   %   $y�Hidden=�6?   5]      5^      5_      