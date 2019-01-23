<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="kipia_web_application.Report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hfUserID" Value="0"/>
      <!--Тут мы показываем наши высплывающие окошки.-->
        <telerik:RadWindowManager ID="radWM" runat="server" EnableShadow="true">
        </telerik:RadWindowManager>
    
    <div style="margin-top: 10px; width: 1700px; height: 30px; padding: 20px;">
        <span style="font-weight: bold;">Отчет по физ лицам ГП "Вода Донбасса": </span>&nbsp;&nbsp;&nbsp;
        с&nbsp;<telerik:RadDatePicker runat="server" ID="dpNewFrom"></telerik:RadDatePicker>
        &nbsp;&nbsp;Пo&nbsp;<telerik:RadDatePicker runat="server" ID="dpNewTo"></telerik:RadDatePicker>
        <asp:CheckBox runat="server" ID="cbNotNewPay" Text="Без оплаты" />
        <asp:CheckBox runat="server" ID="cbNewPay" Text="С оплатой" />
        <telerik:RadButton runat="server" ID="butGenerateNewF" Text="Сформировать" OnClick="butGenerateNewF_OnClick"></telerik:RadButton>
    </div>
    
    
     <div style="margin-top: 10px; width: 1000px; height: 30px; padding: 20px;">
        <span style="font-weight: bold;">Отчет по юр. лицам:</span>&nbsp;&nbsp;&nbsp;
         С&nbsp;<telerik:RadDatePicker runat="server" ID="dpFromU"></telerik:RadDatePicker>
        &nbsp;&nbsp;По&nbsp;<telerik:RadDatePicker runat="server" ID="dpToU"></telerik:RadDatePicker>
        <telerik:RadButton runat="server" ID="RadButton1" Text="Сформировать" OnClick="butGenerateU_Click"></telerik:RadButton>
    </div>
    
    <div style="margin-top: 10px; width: 1000px; height: 30px; padding: 20px;">
        <span style="font-weight: bold;">Реестр по снятию/установке:</span>&nbsp;&nbsp;&nbsp;
        С&nbsp<telerik:RadDatePicker runat="server" ID="dpFromW"></telerik:RadDatePicker>
        &nbsp;&nbsp;По&nbsp;<telerik:RadDatePicker runat="server" ID="dpToW"></telerik:RadDatePicker>
        <telerik:RadButton runat="server" ID="butGenerateW" Text="Сформировать" OnClick="butGenerateW_Click"></telerik:RadButton>
    </div>
    
    <div style="margin-top: 10px; width: 1700px; height: 30px; padding: 20px;">
        <span style="font-weight: bold;">Отчет по физ. лицам КП "Донецкгорводоканал":</span>&nbsp;&nbsp;&nbsp;
         С&nbsp;<telerik:RadDatePicker runat="server" ID="dpFrom"></telerik:RadDatePicker>
        &nbsp;&nbsp;По&nbsp;<telerik:RadDatePicker runat="server" ID="dpTo"></telerik:RadDatePicker>
        <asp:CheckBox runat="server" ID="cbNotPay" Text="Без оплаты" />
        <asp:CheckBox runat="server" ID="cbPay" Text="С оплатой" />
        <telerik:RadButton runat="server" ID="butGenerateF" Text="Сформировать" OnClick="butGenerateF_Click"></telerik:RadButton>
    </div>

    

    <asp:SqlDataSource ID="dsNotPay" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionInfo %>"
        SelectCommand="RetrieveReportNotPay" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="dpFrom" PropertyName="SelectedDate" Name="dateFrom" Type="DateTime" />
            <asp:ControlParameter ControlID="dpTo" PropertyName="SelectedDate" Name="dateTo" Type="DateTime" />
            <asp:ControlParameter ControlID="hfUserID" PropertyName="Value" Name="userID" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="dsPay" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionInfo %>"
        SelectCommand="RetrieveReportPay" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="dpFrom" PropertyName="SelectedDate" Name="dateFrom" Type="DateTime" />
            <asp:ControlParameter ControlID="dpTo" PropertyName="SelectedDate" Name="dateTo" Type="DateTime" />
            <asp:ControlParameter ControlID="hfUserID" PropertyName="Value" Name="userID" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    
    <asp:SqlDataSource ID="dsNewNotPay" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionInfo %>"
        SelectCommand="RetrieveReportNotPay2018" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="dpNewFrom" PropertyName="SelectedDate" Name="dateNewFrom" Type="DateTime" />
            <asp:ControlParameter ControlID="dpNewTo" PropertyName="SelectedDate" Name="dateNewTo" Type="DateTime" />
            <asp:ControlParameter ControlID="hfUserID" PropertyName="Value" Name="userID" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="dsNewPay" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionInfo %>"
        SelectCommand="RetrieveReportPay2018" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="dpNewFrom" PropertyName="SelectedDate" Name="dateNewFrom" Type="DateTime" />
            <asp:ControlParameter ControlID="dpNewTo" PropertyName="SelectedDate" Name="dateNewTo" Type="DateTime" />
            <asp:ControlParameter ControlID="hfUserID" PropertyName="Value" Name="userID" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    
    <asp:SqlDataSource ID="dsUAbonent" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionInfo %>"
        SelectCommand="RetrieveReportPayUAbonent" SelectCommandType="StoredProcedure">
        <SelectParameters>
          <asp:ControlParameter ControlID="dpFromU" PropertyName="SelectedDate" Name="dateFrom" Type="DateTime" />
            <asp:ControlParameter ControlID="dpToU" PropertyName="SelectedDate" Name="dateTo" Type="DateTime" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource runat="server" ID="dsSAbonent" ConnectionString="<%$ ConnectionStrings:ConnectionInfo%>" 
        SelectCommand="RetrieveReportSAbonent" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="dpFromW" PropertyName="SelectedDate" Name="dateFrom" Type="DateTime" />
            <asp:ControlParameter ControlID="dpToW" PropertyName="SelectedDate" Name="dateTo" Type="DateTime" />
            <asp:ControlParameter ControlID="hfUserID" PropertyName="Value" Name="userID" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>

</asp:Content>
