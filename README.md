# NetProxy

Use <br>
```ruby
 services.AddProxy();
```

Call Product Service <br>
```ruby
        public async Task<IActionResult> Index()
        {
            var result = await _productService.GetAllProduct();
            return View();
        }
```


