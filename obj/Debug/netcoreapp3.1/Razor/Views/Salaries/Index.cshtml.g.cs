#pragma checksum "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aeea8c9d363d1316215ef792a8f8f657bd63cd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Salaries_Index), @"mvc.1.0.view", @"/Views/Salaries/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/_ViewImports.cshtml"
using SalaryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/_ViewImports.cshtml"
using SalaryApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/_ViewImports.cshtml"
using SalaryApp.Models.SalaryAppViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aeea8c9d363d1316215ef792a8f8f657bd63cd8", @"/Views/Salaries/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e70ca20e61d8ab254007b8751070a8357853399", @"/Views/_ViewImports.cshtml")]
    public class Views_Salaries_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InstructorIndexData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOvertime", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
 foreach (var item in Model.staffs)
{
    if(item.StaffId == (int)ViewData["StaffId"])
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aeea8c9d363d1316215ef792a8f8f657bd63cd84568", async() => {
                WriteLiteral("Create a new Salary ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-staffid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                                          WriteLiteral(item.StaffId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["staffid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-staffid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["staffid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </p>\n        <div>\n            <dl class=\"row\">\n                <dt class = \"col-sm-2\">\n                    Mã nhân viên:\n                </dt>\n                <dd class = \"col-sm-10\">\n                    ");
#nullable restore
#line 19 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaNV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class = \"col-sm-2\">\n                    Họ và tên:\n                </dt>\n                <dd class = \"col-sm-10\">\n                    ");
#nullable restore
#line 25 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class = \"col-sm-2\">\n                    Chức vụ:\n                </dt>\n                <dd class = \"col-sm-10\">\n                    ");
#nullable restore
#line 31 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Regency));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </dd>
            </dl>
            <hr/>
        </div>
        <div class=""table-reponsive"">
        <table class=""table table-bordered"" style=""min-width: 3000px; text-align:center;"">
            <thead>
                <tr>
                        <th rowspan=""2"">
                            Ngày nhận lương
                        </th>
                        <th rowspan=""2"">
                            Lương cơ bản
                        </th>
                        <th rowspan=""2"">
                            Hỗ trợ
                        </th>
                        <th rowspan=""2"">
                            Giữ Lương
                        </th>
                        <th colspan=""4"">
                            BHXH NV Tham gia
                        </th>
                        <th colspan=""3"">
                            BHXH CT Tham gia
                        </th>
                        <th rowspan=""2"">
                            Tổng phụ cấp
                        ");
            WriteLiteral(@"</th>
                        <th rowspan=""2"">
                            Tổng Lương
                        </th>
                        <th colspan=""3"">
                            Thuế
                        </th>
                        <th colspan=""2"">
                            Tăng ca
                        </th>
                        <th rowspan=""2"">
                            Số ngày làm việc
                        </th>
                        <th rowspan=""2"">
                            Lương ngày công
                        </th>
                        <th rowspan=""2"">
                            Tổng thực lãnh
                        </th>
                        <th rowspan=""2"">
                            Xoá thuộc tính
                        </th>
                        <th rowspan=""2"">
                            Thêm thêm giờ và phụ cấp
                        </th>
                </tr>
                <tr>
                    <th>
                        Lương tham gia BHXH
  ");
            WriteLiteral(@"                  </th>
                    <th>
                        BHXH
                    </th>
                    <th>
                        BHYT
                    </th>
                    <th>
                        BHTN
                    </th>
                    <th>
                        BHXH
                    </th>
                    <th>
                        BHYT
                    </th>
                    <th>
                        BHTN
                    </th>
                    <th>
                        Thu nhập tính thuế
                    </th>
                    <th>
                        Giảm trừ GC
                    </th>
                    <th>
                        Thuế TNCN
                    </th>
                    <th>
                        Số giờ tăng ca
                    </th>
                    <th>
                        Lương tăng ca
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 126 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                 foreach (var item1 in item.Salaries)
                { 
                    var i = 0;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                     foreach (var item2 in item1.Overtimes)
                    {
                    var x = item1.chargeInsurrance;
                    var insurranceStaff = (x*(8+1.5+1)/100);
                    var insurranceCompany = (x*(17.5+3+1)/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n");
#nullable restore
#line 135 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                         if(i > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
");
#nullable restore
#line 148 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                        }
                        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\n                                ");
#nullable restore
#line 151 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                           Write(item1.dayTake.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 151 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                                              Write(item1.dayTake.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 151 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                                                                   Write(item1.dayTake.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                                ");
#nullable restore
#line 154 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                           Write(item1.basicSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                                ");
#nullable restore
#line 157 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                           Write(item1.supportCash);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                                ");
#nullable restore
#line 160 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                           Write(item1.keepSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                                ");
#nullable restore
#line 163 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                           Write(item1.chargeInsurrance);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                                ");
#nullable restore
#line 166 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                            Write(x*8/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                                ");
#nullable restore
#line 169 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                            Write(x*1.5/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                                ");
#nullable restore
#line 172 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                            Write(x*1/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                                ");
#nullable restore
#line 175 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                            Write(x*17.5/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                                ");
#nullable restore
#line 178 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                            Write(x*3/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                                ");
#nullable restore
#line 181 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                            Write(x*1/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n");
#nullable restore
#line 183 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 184 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                          
                            long mySalary = 0;
                            long totalAllowance = 0;
                            long myMoney = 0;
                            if(item2.Allowance != null){
                                totalAllowance = item2.Allowance.bonusKPI + item2.Allowance.lunchCharge + item2.Allowance.phoneCharge + item2.Allowance.uniformsCharge;
                                mySalary = ((item1.basicSalary+totalAllowance)/22*(22 - item2.dayOff));
                                myMoney = (int)(mySalary - insurranceStaff - totalAllowance + item2.Allowance.bonusKPI - 9000000);
                            }
                            else{
                                totalAllowance = 0;
                                mySalary = ((item1.basicSalary+totalAllowance)/22*(22 - item2.dayOff));
                                myMoney = (int)(mySalary - insurranceStaff - 9000000);
                            } 
                            
                            var staffTax = 0;
                            if(myMoney > 80000000){staffTax =(int)((myMoney - 80000000)*0.35 + 18150000);}
                            else if(myMoney > 52000000){staffTax =(int)((myMoney - 52000000)*0.3 + 9750000);}
                            else if(myMoney > 32000000){staffTax =(int)((myMoney - 32000000)*0.25 + 4750000);}
                            else if(myMoney > 18000000){staffTax =(int)((myMoney - 18000000)*0.2 + 1950000);}
                            else if(myMoney > 10000000){staffTax =(int)((myMoney - 10000000)*0.15 + 750000);}
                            else if(myMoney > 5000000){staffTax =(int)((myMoney - 5000000)*0.1 + 250000);}
                            else{staffTax =(int)(myMoney*0.05);}
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\n                            ");
#nullable restore
#line 209 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                       Write(totalAllowance);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 212 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                        Write(item1.totalSalary = item1.basicSalary + totalAllowance);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 215 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                       Write(myMoney);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 218 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                       Write(item1.chargeTax);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 221 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                       Write(staffTax);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 224 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                       Write(item2.overtimeHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 227 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                        Write(@item1.basicSalary/20/8*@item2.overtimeHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 230 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                        Write(22 - item2.dayOff);

#line default
#line hidden
#nullable disable
            WriteLiteral("/22\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 233 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                       Write(mySalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 236 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                        Write(mySalary - insurranceStaff - staffTax + item1.supportCash - item1.keepSalary + item2.overtimeSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aeea8c9d363d1316215ef792a8f8f657bd63cd822323", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-overtimeid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 239 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                                                             WriteLiteral(item2.OverTimeId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["overtimeid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-overtimeid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["overtimeid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n                        if(i == 0){\n                            <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aeea8c9d363d1316215ef792a8f8f657bd63cd824625", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-staffid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 243 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                                                                  WriteLiteral(item.StaffId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["staffid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-staffid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["staffid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 243 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                                                                                                     WriteLiteral(item1.SalaryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["salaryid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-salaryid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["salaryid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </td>\n                        }\n                        <td></td>  \n                        </tr>\n                        <p style=\"display: none\">");
#nullable restore
#line 248 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                                             Write(i = i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</p>\n");
#nullable restore
#line 249 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 249 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n        </div>\n");
#nullable restore
#line 254 "/Users/trungquan/Documents/DILAM/SalaryApp/Views/Salaries/Index.cshtml"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InstructorIndexData> Html { get; private set; }
    }
}
#pragma warning restore 1591
