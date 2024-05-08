import pyperclip


original = '''
{
  "UpstreamPathTemplate": "/api/Product/GetAll",
  "UpstreamHttpMethod": [ "Get" ],
  "DownstreamScheme": "http",
  "DownstreamHostAndPorts": [
    {
      "Host": "productcatalog",
      "Port": 8080
    }
  ],
  "DownStreamPathTemplate": "/api/Product/GetAll"
},
{
  "UpstreamPathTemplate": "/api/Product/Get/{Id}",
  "UpstreamHttpMethod": [ "Get" ],
  "DownstreamScheme": "http",
  "DownstreamHostAndPorts": [
    {
      "Host": "productcatalog",
      "Port": 8080
    }
  ],
  "DownStreamPathTemplate": "/api/Product/Get/{Id}"
},
{
  "UpstreamPathTemplate": "/api/Product/Insert",
  "UpstreamHttpMethod": [ "Post" ],
  "DownstreamScheme": "http",
  "DownstreamHostAndPorts": [
    {
      "Host": "productcatalog",
      "Port": 8080
    }
  ],
  "DownStreamPathTemplate": "/api/Product/Insert"
},
{
  "UpstreamPathTemplate": "/api/Product/Update",
  "UpstreamHttpMethod": [ "Put" ],
  "DownstreamScheme": "http",
  "DownstreamHostAndPorts": [
    {
      "Host": "productcatalog",
      "Port": 8080
    }
  ],
  "DownStreamPathTemplate": "/api/Product/Update"
},
{
  "UpstreamPathTemplate": "/api/Product/Delete/{Id}",
  "UpstreamHttpMethod": [ "Delete" ],
  "DownstreamScheme": "http",
  "DownstreamHostAndPorts": [
    {
      "Host": "productcatalog",
      "Port": 8080
    }
  ],
  "DownStreamPathTemplate": "/api/Product/Delete/{Id}"
},
'''
original = original.replace("productcatalog","orderapi")
# NewWord = input("Enter the new word: ")
modified = original.replace("Product", "OrderDetail")
print(modified)
# ... existing code ...

# Copy the modified string to clipboard
pyperclip.copy(modified)