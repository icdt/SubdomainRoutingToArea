# SubdomainRoutingToArea

相關程式碼位置  
SubdomainRouting.cs  
App_Start/RouteConfig.cs  

目前做法限制  
一個 SubdomainRouting.cs 會綁定一個 Area  
如需好幾個可建多個SubdomainRouting.cs，將其中"Wed"換成要綁定的Area名稱  
routeData.DataTokens.Add("area", "Wed");   
