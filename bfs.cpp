//Ashique Arman

#include<bits/stdc++.h>

using namespace std;

template<typename T>
class Graph{

map<T, list<T>> edg;

public:

    void addEdges(int x, int y){
        edg[x].push_back(y);
        edg[y].push_back(x);
    }

    void bfs(T src){
        map<T, int> visited;
        queue<T> q;

        q.push(src);
        visited[src] = true;

        while(!q.empty()){
            T node = q.front();
            q.pop();

            cout<<node<<" ";


            for(int nbr:edg[node]){
                if(!visited[nbr]){
                    q.push(nbr);

                    visited[nbr] = true;
                }
            }

        }
    }


};


int main(){

    int initialNode = 0;

    Graph<int> g;

    g.addEdges(0, 1);
    g.addEdges(0, 3);
    g.addEdges(1, 2);
    g.addEdges(2, 3);
    g.addEdges(3, 4);
    g.addEdges(4, 5);

    g.bfs(initialNode);

    return 0;
}
