---
title: 捐赠
---
::: tip 联系
如果您对弹幕服务感兴趣，想要赞助作者继续开发，欢迎联系作者 xxwhite@foxmail.com
:::

::: tip 赞助商
目前还没有赞助商
:::

::: tip 捐赠
如果我的项目对您有帮助，您也可以通过下面的链接赞助我（备注弹幕服务器捐赠），较大金额的赞助会永久列在下面的赞助列表中，本项目所有所得赞助，均会用于本项目的持续开发和公共服务的搭建。
:::

<center style="display:flex; justify-content:space-around;">
<img src="@img/other/alipay.png">
<img src="@img/other/wechatpay.png"> 
</center>

截至 {{date}}，本项目共收到捐款 {{receivables}} 元
截至 {{date}}，本项目共支出 {{pay}} 元

> 感谢 `*永虎` 捐赠的 50 元。
> 感谢 `天空铃音` 捐赠的 13.32 元。
> 其他捐赠共计 5.36 元。


<script>
const date = new Date();
const year = date.getFullYear();
const month = date.getMonth() + 1;

const pay = 344;
const receivables = 50 + 13.32 + 5.36;

export default {
  data() {
    return {
      date: `${year}年${month}月1日`,
      pay: pay,
      receivables: receivables
    }
  }
}
</script>