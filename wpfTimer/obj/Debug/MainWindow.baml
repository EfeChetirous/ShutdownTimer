   M S B A M L   `   `   `  ����  wpfTimer    wpfTimer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��143* �6   �� 5      $
��172* �6   �� 5	      $
��202* �6   .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��319��6@   
���   �$	��Top=�6\   $	��517��6t   $��3��6�   �� 5   
   -   5         ��Name$ btnStart��5      $��Shutdown��6#   $
��Left=�66   $��
23,174,0,0q�6Q   $	��Top=�6e   $	��471��6}   $��37��6�   $��3��6�   
���   �$��20(�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF8B4B4B��6#    � Offset$ 0Q�65   � 5      $ White��6#   $ 0.944Q�61   5      5      �� 5   
   -   5         ��Name$ txtHours��5       �� 	MaxLength$ 2��6$   $
��Left=�62   $��26��6M   $��	66,64,0,0q�6Y   	 �� TextWrapping$
	 Wrap=�6l   $	��Top=�6�   $��69��6�   $��14(�6�   6�   �� 5   
   $��Hour :��6   $
��Left=�6!   $��	23,64,0,0q�6<   $	��Top=�6O   $��26��6g   $��42��6s   �� 5   
   -   5        $ txtMins��5      $ 2��6#   $
��Left=�6V   $��26��6q   $��	67,64,0,0q�6}   $
	 Wrap=�6�   $	��Top=�6�   $��69��6�   $��1��6�   
 J� RenderTransformOrigin$
 1,0.615&�6�   �� 5   
   $��Second :��6   $
��Left=�6#   $��	10,64,0,0q�6>   $	��Top=�6Q   $��2��6i   $��26��6y   $��55��6�   �� 5   
   $��Min. :��6   $
��Left=�6!   $��	23,64,0,0q�6<   $	��Top=�6O   $��26��6g   $��39��6s   $��1��6~   $
 1.231,0.538&�6�   �� 5   
   -   5        $ 
txtSeconds��5      $ 2��6&   $
��Left=�6\   $��26��6w   $��	70,64,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $��69��6�   $��2��6�   �� 5   
   -   5         ��Name$ 
lblSeconds��5      $�� ��6$   $
��Left=�6/   $��
66,129,0,0q�6J   $	��Top=�6^   $��2��6v   $	��213��6�   �� 5   
   -   5        $ btnStop��5      $
��Stop��6"   $
��Left=�61   $��
23,238,0,0q�6L   $	��Top=�6`   $	��471��6x   $��37��6�   $��3��6�   
���   �$��20(�6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF8B4B4B��6#   $ 0Q�65   � 5      $ White��6#   $ 0.944Q�61   5       5"      5$      5%      