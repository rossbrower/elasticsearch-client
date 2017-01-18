using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
        ///<param name="name">The name of the template</param>
        ///<param name="body">The template definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutTemplatePut(string name, Stream body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
        ///<param name="name">The name of the template</param>
        ///<param name="body">The template definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutTemplatePutAsync(string name, Stream body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
        ///<param name="name">The name of the template</param>
        ///<param name="body">The template definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutTemplatePut(string name, byte[] body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
        ///<param name="name">The name of the template</param>
        ///<param name="body">The template definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutTemplatePutAsync(string name, byte[] body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
        ///<param name="name">The name of the template</param>
        ///<param name="body">The template definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutTemplatePutString(string name, string body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
        ///<param name="name">The name of the template</param>
        ///<param name="body">The template definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutTemplatePutStringAsync(string name, string body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
        ///<param name="name">The name of the template</param>
        ///<param name="body">The template definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutTemplatePost(string name, Stream body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
        ///<param name="name">The name of the template</param>
        ///<param name="body">The template definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutTemplatePostAsync(string name, Stream body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
        ///<param name="name">The name of the template</param>
        ///<param name="body">The template definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutTemplatePost(string name, byte[] body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
        ///<param name="name">The name of the template</param>
        ///<param name="body">The template definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutTemplatePostAsync(string name, byte[] body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
        ///<param name="name">The name of the template</param>
        ///<param name="body">The template definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutTemplatePostString(string name, string body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
        ///<param name="name">The name of the template</param>
        ///<param name="body">The template definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutTemplatePostStringAsync(string name, string body, Func<IndicesPutTemplateParameters, IndicesPutTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}