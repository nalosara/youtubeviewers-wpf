   M S B A M L   `   `   `  ����F  BDemoApp.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DemoApp.WPF.ComponentsDemoApp.WPF.Components  5      2    ,DemoApp.WPF.Components.YouTubeViewersDetails   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:DemoApp.WPF.Components     5      .��5	      � .+�5
   
   ��    BorderPrimary#��[  5        J� SnapsToDevicePixels$
  True��5       �� Padding$ 20q�5       �� CornerRadius$ 5��5      $��1q�5      ._�5      � .+�5      � ��5      �� 5       �� 
TargetType" �6    .�5      ��  �� Property � y� �� Value$ 	Collapsed=�6;    �� Triggers 5      �� 5   "    �� Binding 6.   �� *HasSelectedYouTubeViewer+ �� Value	 False6[   .a�5   &   ��  � y�$ Visible=�6C   5   #   5      .+�5      �� $��0��6    $%��Please select a YouTube viewer.��6-   5      � 5      	 � IsSharedSizeScope$
	 True��6   ��5       �� 5!      " �6    .�5"      ��  � y�$ 	Collapsed=�6;    5#      �� 5$   "    6.   �� *HasSelectedYouTubeViewer+ True6[   .a�5%   &   ��  � y�$ Visible=�6C   5&   #   5(      
 � RowDefinitions
 5*      �� 5+      $
��auto �6(   �� 5,      $
��auto �6(   �� 5-      $
��auto �6(   .+�50      �� $��0��6    $��20(�6-   ��6;   �� *
Username+� 52      $��1��6   $��	10 10 0 0q�6(    � ColumnDefinitions 53      �� 54      $
��auto �6/    z� SharedSizeGroup$ Label��6<   �� 55      $
��auto �6/   .+�58      �� $��0��6$   $
��Bold"�64   $��Is Subscribed?��6F   �� 59      $��1��6$   $��20 0 0 0q�64   ��6F   �� *IsSubscribedDisplay+5:      � 5<      $��2��6   $��10 5 0 0q�6(    5=      �� 5>      $
��auto �6/   $ Label��6<   �� 5?      $
��auto �6/   .+�5B      �� $��0��6$   $
��Bold"�64   $��
Is Member?��6F   �� 5C      $��1��6$   $��20 0 0 0q�64   ��6F   �� *IsMemberDisplay+5D      5E      5F      5G      5H      5I      