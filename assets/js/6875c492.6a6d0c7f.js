(window.webpackJsonp=window.webpackJsonp||[]).push([[11],{80:function(e,a,t){"use strict";t.r(a);var l=t(0),r=t.n(l),n=t(104),s=t(115),c=t(102),o=t(109),m=t(101),i=t(99);function g(e){var a,t=e.tagName,l=e.count,n=(a=Object(i.usePluralForm)().selectMessage,function(e){return a(e,Object(m.b)({id:"theme.blog.post.plurals",description:'Pluralized label for "{count} posts". Use as much plural forms (separated by "|") as your language support (see https://www.unicode.org/cldr/cldr-aux/charts/34/supplemental/language_plural_rules.html)',message:"One post|{count} posts"},{count:e}))});return r.a.createElement(m.a,{id:"theme.blog.tagTitle",description:"The title of the page for a blog tag",values:{nPosts:n(l),tagName:t}},'{nPosts} tagged with "{tagName}"')}a.default=function(e){var a=e.metadata,t=e.items,l=e.sidebar,i=a.allTagsPath,u=a.name,p=a.count;return r.a.createElement(n.a,{title:'Posts tagged "'+u+'"',description:'Blog | Tagged "'+u+'"',wrapperClassName:"blog-wrapper",searchMetadatas:{tag:"blog_tags_posts"}},r.a.createElement("div",{className:"container margin-vert--lg"},r.a.createElement("div",{className:"row"},r.a.createElement("div",{className:"col col--3"},r.a.createElement(o.a,{sidebar:l})),r.a.createElement("main",{className:"col col--7"},r.a.createElement("h1",null,r.a.createElement(g,{count:p,tagName:u})),r.a.createElement(c.a,{href:i},r.a.createElement(m.a,{id:"theme.tags.tagsPageLink",description:"The label of the link targeting the tag list page"},"View All Tags")),r.a.createElement("div",{className:"margin-vert--xl"},t.map((function(e){var a=e.content;return r.a.createElement(s.a,{key:a.metadata.permalink,frontMatter:a.frontMatter,metadata:a.metadata,truncated:!0},r.a.createElement(a,null))})))))))}}}]);