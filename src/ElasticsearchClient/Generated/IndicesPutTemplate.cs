//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elasticsearch.Client
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    
    
    public partial class ElasticsearchClient
    {
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        /// <param name="body">The template definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesPutTemplatePut(string name, Stream body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            string uri = string.Format("/_template/{0}", name);
            if ((options != null))
            {
                IndicesPutTemplateParameters parameters = options.Invoke(new IndicesPutTemplateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        /// <param name="body">The template definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesPutTemplatePutAsync(string name, Stream body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            string uri = string.Format("/_template/{0}", name);
            if ((options != null))
            {
                IndicesPutTemplateParameters parameters = options.Invoke(new IndicesPutTemplateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        /// <param name="body">The template definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesPutTemplatePut(string name, Byte[] body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            string uri = string.Format("/_template/{0}", name);
            if ((options != null))
            {
                IndicesPutTemplateParameters parameters = options.Invoke(new IndicesPutTemplateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        /// <param name="body">The template definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesPutTemplatePutAsync(string name, Byte[] body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            string uri = string.Format("/_template/{0}", name);
            if ((options != null))
            {
                IndicesPutTemplateParameters parameters = options.Invoke(new IndicesPutTemplateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        /// <param name="body">The template definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesPutTemplatePutString(string name, string body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            string uri = string.Format("/_template/{0}", name);
            if ((options != null))
            {
                IndicesPutTemplateParameters parameters = options.Invoke(new IndicesPutTemplateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        /// <param name="body">The template definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesPutTemplatePutStringAsync(string name, string body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            string uri = string.Format("/_template/{0}", name);
            if ((options != null))
            {
                IndicesPutTemplateParameters parameters = options.Invoke(new IndicesPutTemplateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        /// <param name="body">The template definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesPutTemplatePost(string name, Stream body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            string uri = string.Format("/_template/{0}", name);
            if ((options != null))
            {
                IndicesPutTemplateParameters parameters = options.Invoke(new IndicesPutTemplateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        /// <param name="body">The template definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesPutTemplatePostAsync(string name, Stream body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            string uri = string.Format("/_template/{0}", name);
            if ((options != null))
            {
                IndicesPutTemplateParameters parameters = options.Invoke(new IndicesPutTemplateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        /// <param name="body">The template definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesPutTemplatePost(string name, Byte[] body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            string uri = string.Format("/_template/{0}", name);
            if ((options != null))
            {
                IndicesPutTemplateParameters parameters = options.Invoke(new IndicesPutTemplateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        /// <param name="body">The template definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesPutTemplatePostAsync(string name, Byte[] body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            string uri = string.Format("/_template/{0}", name);
            if ((options != null))
            {
                IndicesPutTemplateParameters parameters = options.Invoke(new IndicesPutTemplateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        /// <param name="body">The template definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesPutTemplatePostString(string name, string body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            string uri = string.Format("/_template/{0}", name);
            if ((options != null))
            {
                IndicesPutTemplateParameters parameters = options.Invoke(new IndicesPutTemplateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        /// <param name="body">The template definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesPutTemplatePostStringAsync(string name, string body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            string uri = string.Format("/_template/{0}", name);
            if ((options != null))
            {
                IndicesPutTemplateParameters parameters = options.Invoke(new IndicesPutTemplateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
    }
}
