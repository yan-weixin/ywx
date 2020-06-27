#pragma checksum "E:\efcore1\TinyShop\Views\Product\CartTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56e880635cc058f94e3a0239ac5b2e133fb95743"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_CartTable), @"mvc.1.0.view", @"/Views/Product/CartTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/CartTable.cshtml", typeof(AspNetCore.Views_Product_CartTable))]
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
#line 1 "E:\efcore1\TinyShop\Views\_ViewImports.cshtml"
using TinyShop;

#line default
#line hidden
#line 2 "E:\efcore1\TinyShop\Views\_ViewImports.cshtml"
using TinyShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56e880635cc058f94e3a0239ac5b2e133fb95743", @"/Views/Product/CartTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd6c6cd47b01eb7f0435ccd35d9e7ec2edf54cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_CartTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(155, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56e880635cc058f94e3a0239ac5b2e133fb957433739", async() => {
                BeginContext(161, 186, true);
                WriteLiteral("\r\n    <title>浏览产品</title>\r\n    <meta charset=\"UTF-8\" />\r\n    <!-- import CSS -->\r\n    <link href=\"https://unpkg.com/element-ui/lib/theme-chalk/index.css\"\r\n          rel=\"stylesheet\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(354, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(356, 10730, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56e880635cc058f94e3a0239ac5b2e133fb957435124", async() => {
                BeginContext(381, 10698, true);
                WriteLiteral(@"
    <el-container id=""app"">
        <el-main>
            <el-row>
                <el-col style=""padding: 10px;"">
                    <el-button type=""primary""
                               v-on:click=""onViewButtonClick"">
                        view视图显示
                    </el-button>
                    <el-button type=""primary""
                               v-on:click=""onTableButtonClick"">
                        Table表单显示
                    </el-button>
                    <el-button type=""success"" plain
                               icon=""el-icon-shopping-cart-2""
                               v-on:click=""onCartTableClick"">
                        我的订单
                    </el-button>
                    <el-button type=""danger"" plain
                               icon=""el-icon-user-solid""
                               v-on:click=""onLoginClick"">
                        登录
                    </el-button>
                </el-col>
            </el-row>
            <el-row");
                WriteLiteral(@">
                <el-col style=""padding: 10px;"">

                    <el-button  type=""success"" 
                                v-on:click=""onTotalClick"">
                        结算
                    </el-button>
                    <el-button>清空列表</el-button>
                </el-col>
            </el-row>
            <el-row>
                <el-col>
                    <el-table :border=""true""
                              :data=""products""
                              style=""width: 100%"">
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""产品编号""
                                         prop=""productNumber"">
                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""产品名称""
                                         p");
                WriteLiteral(@"rop=""productName"">
                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""产品类型""
                                         prop=""productType"">
                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""价格""
                                         prop=""price"">
                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""center""
                                         label=""数量""
                                         prop=""shuliang"">

                        </el-table-column>
                        <el-table-column :sortable=""true""
                                         header-align=""cente");
                WriteLiteral(@"r""
                                         label=""总共""
                                         prop=""total"">

                        </el-table-column>
                        <el-table-column align=""center""
                                         header-align=""center""
                                         label=""操作"">
                            <template slot-scope=""scope"">
                                <el-button size=""mini""
                                           v-on:click=""onAddClick(scope.row.id)"">
                                    增加
                                </el-button>
                                <el-button size=""mini""
                                           v-on:click=""onDownClick(scope.row.id)"">
                                    减少
                                </el-button>
                                <el-button size=""mini""
                                           type=""danger""
                                           v-on:click=""onDeleteBut");
                WriteLiteral(@"tonClick(scope.row.id)"">
                                    删除
                                </el-button>
                            </template>
                        </el-table-column>
                    </el-table>
                </el-col>
            </el-row>

            <el-row>
                <el-col style=""text-align: center;"">
                    <el-form-item label=""总金额""
                                  prop=""a"">

                    </el-form-item>
                </el-col>
            </el-row>
        </el-main>
    </el-container>
    <!-- import Vue before Element -->
    <script src=""https://unpkg.com/vue/dist/vue.js""></script>
    <!-- import JavaScript -->
    <script src=""https://unpkg.com/element-ui/lib/index.js""></script>
    <script src=""https://cdn.bootcdn.net/ajax/libs/axios/0.19.2/axios.js""></script>
    <script>
        const app = new Vue({
            el: ""#app"",
            data: {
                products: [],
                a:'0'
        ");
                WriteLiteral(@"    },
            methods: {
                async GetAllCart(order) {
                    let response = await axios.get('/Product/GetUserCart',{params:{order:order}});

                    if (response.data.code === 'success') {
                        this.products = response.data.data;
                    }else {
                        this.$message({
                            message: '记录获取失败',
                            type: 'error'
                        });
                    }
                },

                onTableButtonClick() {
                    window.location.href = ""/Product/TableOrder"";
                },
                onViewButtonClick() {
                    window.location.href = ""/Product/UserOrder"";
                    },
                onCartTableClick() {
                    window.location.href = ""/Product/Shopping"";
                },
                onLoginClick() {
                    window.location.href = ""/Login/Index"";
                }");
                WriteLiteral(@",
                async onAddClick(id) {
                    let response = await axios.get('/Product/UpdateCart', { params: { id: id } });
                    if (response.data.code === 'success') {
                        this.$message({
                            type: 'success',
                            message: '修改成功！'
                        });
                        this.GetAllCart(this.order);
                    } else {
                        this.$message({
                            message: '修改失败',
                            type: 'error'
                        });
                    }
                },
                async onDownClick(id) {
                    let response = await axios.get('/Product/DownCart', { params: { id: id } });
                    if (response.data.code === 'success') {
                        this.$message({
                            type: 'success',
                            message: '修改成功！'
                        });
          ");
                WriteLiteral(@"              this.GetAllCart(this.order);
                    } else {
                        this.$message({
                            message: '数量是1，无法减少，若要删除，请按删除按钮',
                            type: 'error'
                        });
                    }
                },
                async  onTotalClick() {
                    let response = await axios.get('/Product/JieSuan');

                    if (response.data.code === 'success') {
                        this.$message({
                            type: 'success',
                            message: '结算成功！总金额为：  ' + response.data.data+'    元，请等待外卖送达'
                        });
                        this.a = response.data.data;
                        this.GetAllCart('desc');
                    }else {
                        this.$message({
                            message: '记录获取失败',
                            type: 'error'
                        });
                    }
                        
     ");
                WriteLiteral(@"               },
                onDeleteButtonClick(id) {
                    this.$confirm('确定删除该产品吗？',
                            '提示',
                            {
                                confirmButtonText: '确定',
                                cancelButtonText: '取消',
                                type: 'warning'
                            })
                        .then(async () => {
                            await this.deleteCart(id);
                        })
                        .catch(() => { });;

                },
                async YanUser() {
                    // 检索用户是否登录
                    let response = await axios.get('/Login/YanUser');

                    if (response.data.code === 'success') {
                        this.GetAllCart('desc');
                    } else {
                        this.$message({
                            message: '您还未登录',
                            type: 'error'
                        });
              ");
                WriteLiteral(@"          this.$confirm('您还未登录，请进入登录界面登录,确定进入登录页面吗？',
                            '提示',
                            {
                                confirmButtonText: '确定',
                                cancelButtonText: '取消',
                                type: 'warning'
                            })
                            .then(async () => {
                                window.location.href = ""/Login/Index"";
                            })
                            .catch(async() => {
                                window.location.href = ""/Product/UserOrder"";
                            });;
                    }
                },
                async deleteCart(id) {
                    let response = await axios.get('/Product/DeleteCart/', { params: { id: id } });
                    if (response.data.code === 'success') {
                        this.$message({
                            type: 'success',
                            message: '删除记录成功！'
             ");
                WriteLiteral(@"           });
                        this.GetAllCart(this.order);
                    } else {
                        this.$message({
                            message: '删除记录失败',
                            type: 'error'
                        });
                    }
                }
            },

            mounted() {
                this.YanUser();
                
                
            }
        });
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11086, 11, true);
            WriteLiteral("\r\n\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591